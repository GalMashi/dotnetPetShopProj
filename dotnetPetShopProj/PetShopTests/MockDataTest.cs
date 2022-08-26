using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PetShopTests
{
    [TestClass]
    public class MockData
    {
        public int AnimalId { get; set; }
        public int CategoryId { get; set; }
        public string AnimalName { get; set; }
        public int Age { get; set; }
        public string PictureName { get; set; }
        public string Description { get; set; }
        public int CommentAmount { get; set; }


        [TestMethod]
        public void CheckMockData_GetAllAnimals()
        {
            
        }
    }

    [TestClass]
    public class DataService
    {

        //public List<Animal> GetAllAnimals()
        //{
        //    List<Animal> animals = new List<Animal>()
        //    {
        //        new Animal() { AnimalId = 1, Age = 1, AnimalName = "Parrot", CategoryId = 1, CommentAmount = 0},
        //        new Animal() { AnimalId = 2, Age = 3, AnimalName = "House Cat", CategoryId = 2, CommentAmount = 7},
        //        new Animal() { AnimalId = 3, Age = 6, AnimalName = "Dog", CategoryId = 2, CommentAmount = 5},
        //        new Animal() { AnimalId = 4, Age = 6, AnimalName = "House Cat", CategoryId = 2, CommentAmount = 1},
        //        new Animal() { AnimalId = 5, Age = 2, AnimalName = "Common House Lizard", CategoryId = 3, CommentAmount = 0},
        //        new Animal() { AnimalId = 6, Age = 8, AnimalName = "Hornet", CategoryId = 4, CommentAmount = 3},
        //    };

        //    return animals;
        //}
    }
}
