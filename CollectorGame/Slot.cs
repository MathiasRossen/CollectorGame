using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectorGame
{
    public class Slot
    {
        int quantity;
        int id;

        public int SlotId
        {
            get { return id; }
        }

        public IGameObject SlotObject
        {
            get; set;
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value < 0)
                    quantity = 0;
                else
                    quantity = value;
            }
        }

        public bool Empty
        {
            get
            {
                if (SlotObject == null)
                    return true;
                if (quantity == 0)
                    return true;
                return false;
            }
        }

        public bool Full
        {
            get;
        }

        public IGameObject Drop(int quantity)
        {
            if (!Empty)
            {
                if (SlotObject.Type == ObjectType.Block)
                    Quantity -= 1;
                else
                    Quantity -= quantity;

                return SlotObject;
            }

            return null;
        }

        public Slot(int id)
        {
            this.id = id;
            SlotObject = null;
            quantity = 0;
        }

        public override string ToString()
        {
            if (SlotObject == null)
                return "SLOT_IS_EMPTY";
            else
                return SlotObject.ToString();
        }

        public override bool Equals(object obj)
        {
            if (SlotObject == null)
                return false;
            if (ToString() == obj.ToString())
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
