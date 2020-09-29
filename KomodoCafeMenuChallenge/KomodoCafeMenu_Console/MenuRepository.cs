using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafeMenu_Console
{
    public class MenuRepository
    {
        protected readonly List<MenuRepository> _menuDirectory = new List<MenuRepository>();

        public bool CreateNewMenuItems(MenuRepository newItems)
        {
            int startingCount = _menuDirectory.Count;
            _menuDirectory.Add(newItems);
            bool wasCreated = (_menuDirectory.Count > startingCount) ? true : false;
            return wasCreated;
        }

        public List<MenuRepository> GetAllMenuItems()
        {
            return _menuDirectory;
        }
    }
}
