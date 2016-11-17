using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectorGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Collector Game";
            MainGame mainGame = new MainGame();
            mainGame.Run();
        }
    }
}
