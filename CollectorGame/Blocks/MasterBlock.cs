using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectorGame
{
    public abstract class MasterBlock : IBlock
    {
        protected string identifier;
        protected string name;
        protected bool solid;
        protected bool harvestable;

        public string Identifier
        {
            get
            {
                return identifier;
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

        public ObjectType Type
        {
            get
            {
                return ObjectType.Block;
            }
        }

        public bool Solid
        {
            get
            {
                return solid;
            }
        }

        public bool Harvestable
        {
            get
            {
                return harvestable;
            }
        }

        public MasterBlock(string identifier, string name, bool solid, bool harvestable)
        {
            this.identifier = identifier;
            this.name = name;
            this.solid = solid;
            this.harvestable = harvestable;
        }

        public override bool Equals(object obj)
        {
            if (ToString() == obj.ToString())
                return true;
            return false;
        }

        public override string ToString()
        {
            return name + " type:" + Type.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
