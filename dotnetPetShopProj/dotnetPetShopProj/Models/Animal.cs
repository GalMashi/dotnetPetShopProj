﻿using System.ComponentModel.DataAnnotations;

namespace dotnetPetShopProj.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        public int CategoryId { get; set; }
        public string? AnimalName { get; set; }
        public int Age { get; set; }
        public string? PictureName { get; set; }
        public string? Description { get; set; }
        public int CommentAmount { get; set; }

    }
}
