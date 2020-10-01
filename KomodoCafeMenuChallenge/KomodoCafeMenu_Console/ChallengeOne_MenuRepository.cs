using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafeMenu_Console
{
    public class ChallengeOne_MenuRepository
    {
        private List<ChallengeOne_MenuItems> _menuList = new List<ChallengeOne_MenuItems>();

        //Create
        public bool AddNewMenuItems(ChallengeOne_MenuItems newMenuItem)
        {
            int startingCount = _menuList.Count;
            _menuList.Add(newMenuItem);
            bool wasAdded = (_menuList.Count > startingCount) ? true : false;
            return wasAdded;
        }

        //Read
        public List<ChallengeOne_MenuItems> GetMenuItems()//Read
        {
            return _menuList;
        }


        public bool DeleteMenuItemFromList(string content)
        {

            foreach (ChallengeOne_MenuItems name in _menuList)
            {
                if (name.MealName.ToLower() == content)
                {
                    _menuList.Remove(name);
                    return true;
                }
            }
            return false;
            
        }


        public ChallengeOne_MenuItems GetMenuItemsByName(string mealName)//Helper Method
        {
            foreach (ChallengeOne_MenuItems singleItem in _menuList)
            {
                if (singleItem.MealName.ToLower() == mealName)
                {
                    return singleItem;
                }
            }
            return null;
        }




    }
}
