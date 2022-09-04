namespace dotnetPetShopProj.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        public Category? Category { get; set; }
        public int CategoryId { get; set; }
        public string? AnimalName { get; set; }
        public string? Age { get; set; }
        public string? PictureName { get; set; }
        public string? Description { get; set; }
        public int CommentAmount { get; set; }
        public ICollection<Comment>? Comments { get; set; }
    }
}
