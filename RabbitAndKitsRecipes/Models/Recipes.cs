using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RabbitAndKitsRecipes.Models
{
    public class Recipes
    {
        [Key]
        public int recipeID { get; set; }

        [Required]
        public string recipeName { get; set; }

        public string chef { get; set; }


    }
}
