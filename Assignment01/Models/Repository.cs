using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment01.Models
{

    public class Repository:IRepository
    {
        public IEnumerable<Recipe> RecipeList
        {
            get
            {

                return _newRecipes;
            }
        }

        private static List<Recipe> _newRecipes = new List<Recipe>()
        {new Recipe
                {
                    Name = "Veggie",
                    Process = "Makes enough dough for two 10-12 inch pizzas,"+
                              " 1/2 cups (355 ml) warm water (105°F-115°F),"+
                              " 1 package (2 1/4 teaspoons) of active dry yeast,"+
                              " 3/4 cups (490 g) bread flour,\n"+
                              " 1 tablespoons extra virgin olive oil (omit if cooking pizza in a wood-fired pizza oven),\n"+
                              " 2 teaspoons salt,\n"+
                              " 2 teaspoon sugar.",
                    Ingredient ="Firm mozzarella cheese,Tomato source,Mushrooms,Bell peppers,",
                    Id=1,
                    Image="/Image/Veggie pizza.jpg"
                },
        new Recipe
                {
                    Name = "Hawaiian",
                    Ingredient = "Succulent pineapple and slices of ham topped with an extra layer of cheese.",
                    Process = " 1-1/2 cups uncooked multigrain bow tie pasta (about 4 ounces),"+
                                 " 1 pound ham (90% lean),"+
                                 " 1 cup sliced fresh mushrooms, divided, "+
                                 " 1/2 cup chopped onion, "+
                                 " 1/2 cup chopped pineapple, "+
                                 " 1 teaspoon dried oregano, "+
                                 " 1/2 teaspoon garlic powder, "+
                                 " 1/4 teaspoon onion powder, "+
                                 " 1/8 teaspoon pepper, "+
                                 " 1 can (15 ounces) tomato sauce, "+
                                 " 1/2 cup shredded part-skim mozzarella cheese, divided, "+
                                 " 2 tablespoons grated Parmesan cheese, divided",
                    Id=2,
                    Image ="/Image/Hawaiian.jpg"
                },
            new Recipe
                {
                    Name = "Pepperoni Feast",
                    Ingredient = "Lots and lots of pepperoni topped with an extra layer of cheese.",
                    Process = " 1 pound lean ground beef (90% lean), "+
                                " 1 cup sliced fresh mushrooms, divided,  "+
                                " 1 tablespoons extra virgin olive oil (omit if cooking pizza in a wood-fired pizza oven),"+
                                " 2 teaspoons salt,"+
                                " 2 teaspoon sugar.",
                    Id=3,
                    Image ="/Image/Pepperoni.jpg"
                }
        };


        public void AddRecipes(Recipe recipes)
        {

            _newRecipes.Add(recipes);
        }

        public Recipe FindById(int id)
        {
            return _newRecipes.Find(item => item.Id == id);
        }

        public Recipe Update(Recipe updateRecipes)
        {
            int index = _newRecipes.FindIndex(item => item.Id == updateRecipes.Id);
            _newRecipes[index] = updateRecipes;
            return _newRecipes[index];
        }

    }
}
