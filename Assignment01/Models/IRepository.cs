using System;
using System.Linq;
using System.Collections.Generic;
namespace Assignment01.Models
{
    public interface IRepository
    {
        IEnumerable<Recipe> RecipeList { get; }

        void AddRecipes(Recipe recipes);
        Recipe FindById(int id);
        Recipe Update(Recipe updateRecipes);
    }
}
