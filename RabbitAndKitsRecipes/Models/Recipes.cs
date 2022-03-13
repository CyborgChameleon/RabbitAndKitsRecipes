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

        public string description { get; set; }

        //add the following
        //  -description
        //  -ingredient
        //  -instructions
        //  -instructions with photo

        //in the following places
        //  -Recipes.cs
        //  -HomeController.cs??? not sure if necessary-> if not delete that part
        //  -


        //TESTING ZONE
        //A.Add controler with recipe model (install package if needed)
        //B.add database via package manager console
        //  1.enable-migrations
        //  2.add-migration "initialsetup"
        //  3.update-database
        //


    }
}
