using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectorGame
{
    public class Wall : MasterBlock
    {
        public Wall(Point position)
            :base("#", "Wall", true, false)
        {
            Position = position;
        }
    }
}
