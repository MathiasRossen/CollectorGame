using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectorGame
{
    public interface IItem : IGameObject
    {
        int Value { get; }
        int Quantity { get; set; }
        int Power { get; }
        int Durability { get; set; }
        int MaxDurability { get; }
    }
}
