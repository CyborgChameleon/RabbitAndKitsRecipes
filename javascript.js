import {recipes} from './recipes.js';

var index=1;

document.getElementById("name").innerHTML =recipes[index].food;
	
document.getElementById("ingredients").innerHTML =recipes[index].ingredients.map((recipe)=>
	`
		<li>${recipe.ingredient}</li>
	`
).join("");
			
document.getElementById("instructions").innerHTML =recipes[index].instructions.map((instruction)=>
	`
		<li>${instruction}</li>
	`
).join("");



