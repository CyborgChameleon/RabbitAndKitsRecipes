var index=1;

var recipes=[
	{
		food:"pizza dough",
		
		ingredients:[
			{ingredient:"flour", quantity:2, unit:"cup"}, 
			{ingredient:"flour"},
			{ingredient:"flour"}
		],
		instructions:[
			"step1 instructions",
			"step2 instructions"
		]
	},
	{
		food:"soba noodle dough", 
		
		ingredients:[
			"buckwheat flour", 
			"soda"
		]
	},
	{food:"eggnog"},
	{food:"moosemilk"},
	{
		food:"food",
		
		ingredients:{
			ingredient:"ingredient",
		},
			
		
		instructions:[
			"Step 1...",
		]
	}
];


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




