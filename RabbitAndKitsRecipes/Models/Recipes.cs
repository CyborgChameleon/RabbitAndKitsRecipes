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
        [Display(Name ="Recipe")]
        public string recipeName { get; set; }

        [Display(Name = "Chef")]
        public string chef { get; set; }

        [Display(Name = "Description of Recipe")]
        public string descriptionOfRecipe { get; set; }

        [Display(Name = "List of Ingredients")]
        public List<ingredient> ingredientList { get; set; }



        //add the following
        //  -ingredient
        //  -instructions
        //  -instructions with photo

        //in the following places
        //  -Recipes.cs


        //TESTING ZONE
        //A.install package microsoft.EntityFrameworkCore.Design
        //B.Add controler with recipe model 
        //		(however if they require you to add other package 
        //		try skipping A to minimize the amount of package needed)
        //C.add database via package manager console
        //  1.add-migration "initialsetup"
        //  2.update-database
        //


    }

    public class ingredientList
    {
        [Display(Name = "Ingredient")]
        public string ingredientName { get; set; }


    }
}
