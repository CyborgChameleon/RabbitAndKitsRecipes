using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RabbitAndKitsRecipes.Models
{
    public class RecipeModel
    {
        //[Required]
        //public int recipeID { get; set; }
        //i dont know if that is necessary?
        [Required]
        public string recipeName { get; set; }
        
        public string chef { get; set; }


        //this is clean version
        //things to add
        //    description
        //    ingredients
        //    instructions

    }
}
