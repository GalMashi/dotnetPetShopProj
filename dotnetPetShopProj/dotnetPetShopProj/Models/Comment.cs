namespace dotnetPetShopProj.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public int AnimalId { get; set; }
        public string? CommentContent { get; set; }
    }
}
