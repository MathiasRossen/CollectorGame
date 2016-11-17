using System;
using System.Collections.Generic;

namespace CollectorGame
{
    public class Inventory
    {
        List<Slot> slotList;
        int selectedSlot = 1;

        public int Slots
        {
            get; set;
        }

        public Slot SelectedSlot
        {
            get
            {
                return slotList.Find(x => x.SlotId == selectedSlot);
            }
        }

        public int SelectedSlotNum
        {
            get
            {
                return selectedSlot;
            }
            set
            {
                if (value > slotList.Count)
                    selectedSlot = slotList.Count;
                else if (value < 1)
                    selectedSlot = 1;
                else
                    selectedSlot = value;
            }
        }

        public bool Full
        {
            get { return !slotList.Exists(x => x.Empty == true); }
        }

        public Inventory(int slots)
        {
            slotList = new List<Slot>();
            Slots = slots;
            InitializeInventory();
        }

        private void InitializeInventory()
        {
            for(int i = 1; i <= Slots; i++)
            {
                slotList.Add(new Slot(i));
            }
        }

        public void AddToInventory(IGameObject gameObject)
        {
            if (!Full)
            {
                if (ObjectExists(gameObject))
                    slotList[FindItemIndex(gameObject)].Quantity += 1;
                else
                {
                    int slotToFill = FindNextEmptySlot();
                    slotList[slotToFill].SlotObject = gameObject;
                    slotList[slotToFill].Quantity += 1;
                }
            }
            else
                Events.Add("Inventory is full");

        }

        public int FindItemIndex(IGameObject gameObject)
        {
            return slotList.FindIndex(x => x.Equals(gameObject));
        }

        public int FindNextEmptySlot()
        {
            return slotList.FindIndex(x => x.Empty);
        }

        public bool ObjectExists(IGameObject gameObject)
        {
            return slotList.Exists(x => x.Equals(gameObject));
        }
    }
}
