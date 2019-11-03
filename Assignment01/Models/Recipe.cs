using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment01.Models
{
    public class Recipe
    {
        //private static int _id ;
        public String Name { get; set; }
        public int Id { get; set; }
        public String Process { get; set; }
        public String Ingredient{ get; set; }
        public String Review { get; set; }
        public string Image { get; set; }
    }


}
