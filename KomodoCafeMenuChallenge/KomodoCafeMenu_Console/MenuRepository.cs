using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafeMenu_Console
{
    public class MenuRepository
    {
        private List<MenuItems> _menuList = new List<MenuItems>();

        //Create
        public bool AddNewMenuItems(MenuItems newMenuItem)
        {
            int startingCount = _menuList.Count;
            _menuList.Add(newMenuItem);
            bool wasAdded = (_menuList.Count > startingCount) ? true : false;
            return wasAdded;
        }

        //Read
        public List<MenuItems> GetMenuItems()//Read
        {
            return _menuList;
        }

        //Update

        //Delete
        //public bool DeleteMenuItemFromList(string mealName)
        //{
        //    MenuItems singleItem = GetMenuItemsByName(mealName);

        //    if(singleItem == null)
        //    {
        //        return false;
        //    }

        //    int initialCount = _menuList.Count;
        //    _menuList.Remove(singleItem);

        //    if(initialCount > _menuList.Count)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public bool DeleteMenuItemFromList(MenuItems content)
        {
            bool deleteResult = _menuList.Remove(content);
            return deleteResult;
        }


        public MenuItems GetMenuItemsByName(string mealName)//Helper Method
        {
            foreach (MenuItems singleItem in _menuList)
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
