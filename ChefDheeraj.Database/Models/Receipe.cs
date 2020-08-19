using System;
using System.Collections.Generic;

namespace ChefDheeraj.Database.Models
{
    public class Receipe : EntityBase
    {
        public string Title { get; set; }
        public IList<Step> Steps { get; set; }
        public IList<Image> Images { get; set; }
        public IList<Ingredient> Ingredients { get; set; }
        public DateTime CreatedDateTime { get; set; }

        public Level Level { get; set; }
        public Receipe()
        {
            Images = new List<Image>();
            Steps = new List<Step>();
            Ingredients = new List<Ingredient>();
        }
    }

    public enum Level
    {
        Easy = 1,
        Medium = 2,
        Difficult = 3,
    }
}
