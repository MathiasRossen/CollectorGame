using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectorGame
{
    public class MasterItem : IItem
    {
        protected string identifier;
        protected int durability;
        protected int maxDurability;
        protected string name;
        protected int power;
        protected int quantity;
        protected ObjectType type;
        protected int value;

        public int Durability
        {
            get
            {
                return durability;
            }
            set
            {
                if (value > maxDurability)
                    durability = maxDurability;
                else if (value < 0)
                    durability = 0;
                else
                    durability = value;
            }
        }

        public string Identifier
        {
            get
            {
                return identifier;
            }
        }

        public int MaxDurability
        {
            get
            {
                return maxDurability;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public Point Position
        {
            get; set;
        }

        public int Power
        {
            get
            {
                return power;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value < 1)
                    quantity = 1;
                else
                    quantity = value;
            }
        }

        public ObjectType Type
        {
            get
            {
                return type;
            }
        }

        public int Value
        {
            get
            {
                return value;
            }
        }

        public MasterItem()
        {
            type = ObjectType.Item;
            value = 10;
            quantity = 1;
        }
    }
}
