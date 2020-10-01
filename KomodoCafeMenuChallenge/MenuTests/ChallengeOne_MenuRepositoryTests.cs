using System;
using System.Collections.Generic;
using KomodoCafeMenu_Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MenuTests
{
    [TestClass]
    public class ChallengeOne_MenuRepositoryTests
    {
        [TestMethod]
        public void AddNewMenuItems_ShouldReturnCorrectBoolean()
        {
            ChallengeOne_MenuItems newMenuItems = new ChallengeOne_MenuItems();
            ChallengeOne_MenuRepository repository = new ChallengeOne_MenuRepository();

            bool wasCreated = repository.AddNewMenuItems(newMenuItems);
            Assert.IsTrue(wasCreated);
        }
        [TestMethod]
        public void GetMenuItems_ShouldReturnAllItemsInCollection()
        {
            ChallengeOne_MenuItems newObject = new ChallengeOne_MenuItems();
            ChallengeOne_MenuRepository repo = new ChallengeOne_MenuRepository();
            repo.AddNewMenuItems(newObject);

            List<ChallengeOne_MenuItems> listOfMenuItems = repo.GetMenuItems();

            bool menuDirectoryHasNewItems = listOfMenuItems.Contains(newObject);
            Assert.IsTrue(menuDirectoryHasNewItems);
        }

        private ChallengeOne_MenuRepository _repo;
        private ChallengeOne_MenuItems _content;
        [TestInitialize]

        public void Arrange()
        {
            _repo = new ChallengeOne_MenuRepository();
            _content = new ChallengeOne_MenuItems(1, "Hamburger", "100% Angus Beef", "lettuce, mayo, onion, cheese, bacon, tomato, pickle", 6);
            _repo.AddNewMenuItems(_content);

        }
        [TestMethod]
        public void DeleteMenuItems_ShouldReturnTrue()
        {
            ChallengeOne_MenuItems foundMenuItem = _repo.GetMenuItemsByName("Hamburger");
            bool removeMenuItem = _repo.DeleteMenuItemFromList(foundMenuItem);
            Assert.IsTrue(removeMenuItem);

        }
    }
}
