using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectorGame
{
    public class GameObjectFactory
    {
        public IGameObject CreateGameObject(IGameObject gameObject)
        {
            if(gameObject.Type == ObjectType.Block)
            {
                switch (gameObject.Name)
                {
                    case "Copper":
                        return new Copper(gameObject.Position);

                    default: return null;
                }
            }

            if(gameObject.Type == ObjectType.Item)
            {
                switch (gameObject.Name)
                {
                    default: return null;
                }
            }

            return null;
        }
    }
}
