using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectorGame
{
    public abstract class MasterCreature : ICreature
    {
        protected string identifier;
        protected string name;
        protected ObjectType type;

        public string Identifier
        {
            get { return identifier; }
        }
        public string Name
        {
            get { return name; }
        }
        public Point Position
        {
            get; set;
        }
        public ObjectType Type
        {
            get { return type; }
        }

        public abstract void Move(string input, GameWorld gameWorld);

        public virtual bool Collision(string input, GameWorld gameWorld)
        {
            return false;
        }

        public Point InputToPoint(string input)
        {
            switch (input)
            {
                case "w":
                case "y":
                    return new Point(Position.X, Position.Y - 1);

                case "s":
                case "h":
                    return new Point(Position.X, Position.Y + 1);

                case "a":
                case "g":
                    return new Point(Position.X - 1, Position.Y);

                case "d":
                case "j":
                    return new Point(Position.X + 1, Position.Y);

                default:
                    return Position;
            }
        }
    }
}
