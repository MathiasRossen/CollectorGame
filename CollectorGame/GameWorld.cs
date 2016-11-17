using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectorGame
{
    public class GameWorld
    {
        List<IGameObject> worldObjects;

        int width = 18;
        int height = 12;

        public int Width
        {
            get { return width; }
        }

        public int Height
        {
            get { return height; }
        }

        public GameWorld(Player player)
        {
            worldObjects = new List<IGameObject>();
            GenerateWorld();
            worldObjects.Add(player);
        }

        public void GenerateWorld()
        {
            for(int y = 0; y < height; y++)
            {
                for(int x = 0; x < width; x++)
                {
                    if (y == 0 || y == height - 1 || x == 0 || x == width - 1)
                        worldObjects.Add(new Wall(new Point(x, y)));
                    else if(y == 1)
                        worldObjects.Add(new Copper(new Point(x, y)));
                    else
                        worldObjects.Add(new Ground(new Point(x, y)));
                }
            }
        }

        public void DisplayWorld()
        {
            for(int y = 0; y < height; y++)
            {
                for(int x = 0; x < width; x++)
                {
                    Console.Write(GetTopObjectOnTile(new Point(x, y)).Identifier + " ");
                }
                Console.WriteLine();
            }
        }

        public IGameObject GetTopObjectOnTile(Point position)
        {
            return worldObjects.FindAll(x => x.Position.Equals(position)).Last();
        }

        public IBlock GetTile(Point position)
        {
            return (IBlock)worldObjects.Find(x => x.Type == ObjectType.Block && x.Position.Equals(position));
        }

        public int GetTileIndex(Point position)
        {
            return worldObjects.FindIndex(x => x.Type == ObjectType.Block && x.Position.Equals(position));
        }

        public IItem GetItem(Point position)
        {
            return (IItem)worldObjects.Find(x => x.Type == ObjectType.Item && x.Position.Equals(position));
        }

        public int GetItemIndex(Point position)
        {
            return worldObjects.FindIndex(x => x.Type == ObjectType.Item && x.Position.Equals(position));
        }

        public IBlock HarvestTile(Point position)
        {
            IBlock blockToReturn = GetTile(position);
            RemoveBlock(position);
            return blockToReturn;
        }

        public void PlaceBlock(IBlock block)
        {
            //IBlock tileToChange = GetTile(block.Position);
            //tileToChange = block;

            //worldObjects.Remove(GetTile(block.Position));
            //worldObjects.Add(block);

            int index = GetTileIndex(block.Position);
            worldObjects[index] = block;
        }

        public void RemoveBlock(Point position)
        {
            //IBlock tileToChange = GetTile(position);
            //tileToChange = new Ground(position);

            //worldObjects.Remove(GetTile(position));
            //worldObjects.Add(new Ground(position));

            int index = GetTileIndex(position);
            worldObjects[index] = new Ground(position);
        }

        public void RemoveItem(Point position)
        {
            int index = GetItemIndex(position);
            worldObjects.RemoveAt(index);
        }
    }
}
