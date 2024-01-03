using dotnetPetShopProj.Authorization;
using dotnetPetShopProj.Data;
using dotnetPetShopProj.Repositories;
using dotnetPetShopProj.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
//builder.Services.AddAuthentication();
builder.Services.AddScoped<IPetShopService, PetShopService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddTransient<IAnimalRepository, AnimalRepository>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddTransient<ICommentRepository, CommentRepository>();
builder.Services.AddDbContext<PetShopContext>(options => options.UseSqlite("Data Source=c:\\temp\\PetShop.db"));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

using (var scope = app.Services.CreateScope())
{
    var Ctx = scope.ServiceProvider.GetRequiredService<PetShopContext>();
    Ctx.Database.EnsureDeleted();
    Ctx.Database.EnsureCreated();
}



app.UseStaticFiles();

app.UseRouting();

//app.UseMiddleware<BasicAuthMiddleware>();

app.UseAuthorization();

//app.UseAuthentication();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute("Default", "{controller=Home}/{action=Index}");
});


app.MapRazorPages();

app.Run();
