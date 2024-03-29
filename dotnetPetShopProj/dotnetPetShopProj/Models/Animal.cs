﻿
namespace dotnetPetShopProj.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        public string? AnimalName { get; set; }
        public string? Age { get; set; }
        public string? PicturePath { get; set; }
        public string? Description { get; set; }
        public int CommentAmount { get; set; }
        public ICollection<Comment>? Comments { get; set; }


        public Category? AnimalCategory { get; set; }
        public int CategoryId { get; set; }
    }
}
