using System;
using System.Collections.Generic;
using KomodoCafeMenu_Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MenuTests
{
    [TestClass]
    public class MenuRepositoryTests
    {
        [TestMethod]
        public void AddNewMenuItems_ShouldReturnCorrectBoolean()
        {
            MenuItems newMenuItems = new MenuItems();
            MenuRepository repository = new MenuRepository();

            bool wasCreated = repository.AddNewMenuItems(newMenuItems);
            Assert.IsTrue(wasCreated);
        }
        [TestMethod]
        public void GetMenuItems_ShouldReturnAllItemsInCollection()
        {
            MenuItems newObject = new MenuItems();
            MenuRepository repo = new MenuRepository();
            repo.AddNewMenuItems(newObject);

            List<MenuItems> listOfMenuItems = repo.GetMenuItems();

            bool menuDirectoryHasNewItems = listOfMenuItems.Contains(newObject);
            Assert.IsTrue(menuDirectoryHasNewItems);
        }

        private MenuRepository _repo;
        private MenuItems _content;
        [TestInitialize]

        public void Arrange()
        {
            _repo = new MenuRepository();
            _content = new MenuItems();
            _repo.GetMenuItemsByName();

        }
        [TestMethod]
        public void DeleteMenuItems_ShouldReturnTrue()
        {
            MenuItems foundMenuItems = _repo.GetMenuItemsByName();
            bool removeMenuItem = _repo.DeleteMenuItems(foundMenuItems);
            Assert.IsTrue(removeMenuItem);

        }
    }
}
