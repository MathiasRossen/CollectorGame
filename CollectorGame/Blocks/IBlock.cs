using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectorGame
{
    public interface IBlock : IGameObject
    {
        bool Solid { get; }
        bool Harvestable { get; }
    }
}
