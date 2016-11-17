using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectorGame
{
    public class Copper : MasterBlock
    {
        public Copper(Point position)
            :base("+", "Copper", true, true)
        {
            Position = position;
        }
    }
}
