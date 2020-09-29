using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafeMenu_Console
{
    public class MenuItems
    {
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string MealDescription { get; set; }
        public string ListOfIngredients { get; set; }
        public float MealPrice { get; set; }
        public MenuItems() { }
        public MenuItems(int mealNum, string mealName, string mealDesc, string listOfIng, float mealPrice)
        {
            MealNumber = mealNum;
            MealName = mealName;
            MealDescription = mealDesc;
            ListOfIngredients = listOfIng;
            MealPrice = mealPrice;
        }

      
       
    }
}
