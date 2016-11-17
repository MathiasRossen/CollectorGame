using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectorGame
{
    public class Ground : MasterBlock
    {
        public Ground(Point position)
            :base("-", "Ground", false, false)
        {
            Position = position;
        }
    }
}
