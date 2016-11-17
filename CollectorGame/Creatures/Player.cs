using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectorGame
{
    public class Player : MasterCreature
    {
        private Inventory inventory;

        public Player(Point position)
        {
            inventory = new Inventory(9);
            Position = position;
            name = "hero";
            identifier = name.Substring(0, 1).ToUpper();
        }

        public override bool Collision(string input, GameWorld gameWorld)
        {
            IBlock nextTile = gameWorld.GetTile(InputToPoint(input));

            if (nextTile.Solid)
            {
                if (nextTile.Harvestable)
                {
                    if(!inventory.Full)
                    {
                        inventory.AddToInventory(gameWorld.HarvestTile(nextTile.Position));
                    }
                }

                return true;
            }

            return false;
        }

        public override void Move(string input, GameWorld gameWorld)
        {
            if (!Collision(input, gameWorld))
                Position = InputToPoint(input);
        }
    }
}
