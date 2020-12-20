using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatASP.App.Models
{
    public class Cat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        public string ImageUrl { get; set; }
    }
}
