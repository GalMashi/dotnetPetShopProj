namespace dotnetPetShopProj.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string? CommentContent { get; set; }

        public Animal Animal { get; set; }
        public int AnimalId { get; set; }

    }
}
