using Microsoft.EntityFrameworkCore;

namespace dotnetPetShopProj.Models
{
    //[PrimaryKey(nameof(CommentId))]
    public class Comment
    {
        public int CommentId { get; set; }
        public string? CommentContent { get; set; }

        public Animal? Animal { get; set; }
        public int CommAnimalId { get; set; }

    }
}
