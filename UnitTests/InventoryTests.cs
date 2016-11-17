using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectorGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class InventoryTests
    {
        Inventory inventory;

        [TestInitialize]
        public void Initialize()
        {
            inventory = new Inventory(9);
        }

        [TestMethod]
        public void InventorySlotOneByDefault()
        {
            Assert.AreEqual(1, inventory.SelectedSlot.SlotId);
        }

        [TestMethod]
        public void InventoryCanChangeSlot()
        {
            inventory.SelectedSlotNum = 2;

            Assert.AreEqual(2, inventory.SelectedSlot.SlotId);
        }

        [TestMethod]
        public void InventoryIsNotFull()
        {
            Assert.AreEqual(false, inventory.Full);
        }

        [TestMethod]
        public void CanAddToInventory()
        {
            inventory.AddToInventory(new Wall(new Point()));

            Assert.AreEqual(false, inventory.SelectedSlot.Empty);
        }

        [TestMethod]
        public void CanFindMatchingObject()
        {
            IGameObject objectToMatch = new Wall(new Point());
            inventory.AddToInventory(new Wall(new Point()));

            Assert.AreEqual(true, inventory.ObjectExists(objectToMatch));
        }

        [TestMethod]
        public void CanAddSeveralItemsToInventory()
        {
            inventory.AddToInventory(new Wall(new Point()));
            inventory.AddToInventory(new Ground(new Point()));
            inventory.AddToInventory(new Wall(new Point()));
            inventory.AddToInventory(new Wall(new Point()));

            Assert.AreEqual(3, inventory.SelectedSlot.Quantity);

            inventory.SelectedSlotNum = 2;

            Assert.AreEqual(1, inventory.SelectedSlot.Quantity);
        }

        [TestMethod]
        public void CanDropItems()
        {
            inventory.AddToInventory(new Wall(new Point()));

            IGameObject expected = new Wall(new Point());
            IGameObject actual = inventory.SelectedSlot.Drop(1);

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(true, inventory.SelectedSlot.Empty);
        }

        [TestMethod]
        public void CannotFindEmptyWithFullInventory()
        {
            inventory = new Inventory(1);
            inventory.AddToInventory(new Wall(new Point()));

            int index = inventory.FindNextEmptySlot();

            Assert.AreEqual(-1, index);
            Assert.AreEqual(true, inventory.Full);
        }

        [TestMethod]
        public void CannotAddToFullInventory()
        {
            inventory = new Inventory(1);
            inventory.AddToInventory(new Wall(new Point()));
            inventory.AddToInventory(new Ground(new Point()));

            Assert.AreEqual("Inventory is full", Events.EventList[0]);
        }

        [TestMethod]
        public void CannotSelectNotExistingSlot()
        {
            inventory = new Inventory(5);

            inventory.SelectedSlotNum = 8;

            Assert.AreEqual(5, inventory.SelectedSlotNum);

            inventory.SelectedSlotNum = -5;

            Assert.AreEqual(1, inventory.SelectedSlotNum);
        }
    }
}
