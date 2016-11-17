using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectorGame
{
    public interface ICreature : IGameObject
    {
        void Move(string input, GameWorld gameWorld);
        bool Collision(string input, GameWorld gameWorld);
    }
}
