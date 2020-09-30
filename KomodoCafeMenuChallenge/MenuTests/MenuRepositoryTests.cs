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
            _content = new MenuItems(1, "Hamburger", "100% Angus Beef", "lettuce, mayo, onion, cheese, bacon, tomato, pickle", 6);
            _repo.AddNewMenuItems(_content);

        }
        [TestMethod]
        public void DeleteMenuItems_ShouldReturnTrue()
        {
            MenuItems foundMenuItem = _repo.GetMenuItemsByName("Hamburger");
            bool removeMenuItem = _repo.DeleteMenuItemFromList(foundMenuItem);
            Assert.IsTrue(removeMenuItem);

        }
    }
}
