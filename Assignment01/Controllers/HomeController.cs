using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment01.Models;
using System.Web;

namespace Assignment01.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository;
        public HomeController(IRepository repository)
        {
            this.repository = repository;
        }
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult RecipeList()
        {

            return View(repository.RecipeList);
        }


        [HttpGet]
        public ViewResult AddRecipe()
        {
            return View();
        }
        [HttpPost]
        public ViewResult AddRecipe(Recipe newRecipe)
        {
            repository.AddRecipes(newRecipe);
            return View(newRecipe);
        }

        public ViewResult ViewRecipe(int id)
        {
            return View(repository.FindById(id));
        }

        [HttpGet]
        public ViewResult ReviewRecipe(int id)
        {
            return View(repository.FindById(id));
        }

        [HttpPost]
        public ViewResult ReviewRecipe(Recipe newRecipe)
        {
            Recipe ur = repository.FindById(newRecipe.Id);
            ur.Review = newRecipe.Review;
            return View("ViewRecipe", repository.Update(ur));
        }

    }
}
