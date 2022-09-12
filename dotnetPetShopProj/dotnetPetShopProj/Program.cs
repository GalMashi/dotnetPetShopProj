using dotnetPetShopProj.Data;
using dotnetPetShopProj.Repositories;
using dotnetPetShopProj.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IPetShopService, PetShopService>();
builder.Services.AddTransient<IAnimalRepository, AnimalRepository>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddDbContext<AnimalsContext>(options => options.UseSqlite("Data Source=c:\\temp\\PetShopAnimals.db"));
builder.Services.AddDbContext<CategoryContext>(options => options.UseSqlite("Data Source=c:\\temp\\PetShopCategories.db"));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

//using (var scope = app.Services.CreateScope())
//{
//    var animalsCtx = scope.ServiceProvider.GetRequiredService<AnimalsContext>();
//    var categoriesCtx = scope.ServiceProvider.GetRequiredService<CategoryContext>();
//    animalsCtx.Database.EnsureDeleted();
//    categoriesCtx.Database.EnsureDeleted();
//    categoriesCtx.Database.EnsureCreated();
//    animalsCtx.Database.EnsureCreated();
//}



app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute("Default", "{controller=Home}/{action=Index}");
});


app.MapRazorPages();

app.Run();
