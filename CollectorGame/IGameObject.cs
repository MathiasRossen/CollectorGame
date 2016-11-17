using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectorGame
{
    public enum ObjectType { Block, Item, Creature }

    public interface IGameObject
    {
        string Identifier { get; }
        string Name { get; }
        Point Position { get; set; }
        ObjectType Type { get; }
    }
}
