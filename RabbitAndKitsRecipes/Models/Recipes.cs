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
        //  -ingredient
        //  -instructions
        //  -instructions with photo

        //in the following places
        //  -Recipes.cs
        //  -HomeController.cs??? try deleting that part before testing
        //  -


        //TESTING ZONE
				//A.install package microsoft.EntityFrameworkCore.Design
        //B.Add controler with recipe model 
				//		(however if they require you to add other package 
				//		try skipping A to minimize the amount of package needed)
        //C.add database via package manager console
        //  1.enable-migrations->try skipping that part
        //  2.add-migration "initialsetup"
        //  3.update-database
        //


    }
}
