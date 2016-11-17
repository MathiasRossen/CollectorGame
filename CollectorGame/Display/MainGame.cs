using System;

namespace CollectorGame
{
    class MainGame
    {
        public void Run()
        {
            bool running = true;
            string input;
            Player player = new Player(new Point(3, 3));
            GameWorld gameWorld = new GameWorld(player);

            do
            {
                Console.Clear();
                gameWorld.DisplayWorld();
                input = GetInput();
                player.Move(input, gameWorld);
            }
            while (running);

            //    Player player = new Player();

            //    do
            //    {
            //        Console.WriteLine();

            //        if(!player.Inventory.EmptyHand)
            //            Console.WriteLine("Current selected item: {0}", player.Inventory.SelectedItem.Name);
            //        else
            //            Console.WriteLine();

            //        Console.WriteLine();
            //        Events.DisplayEvents(3);
            //        input = GetInput();

            //        switch (input)
            //        {
            //            case "w":
            //            case "s":
            //            case "a":
            //            case "d":
            //                player.Move(input, gameWorld);
            //                break;

            //            case "y":
            //            case "h":
            //            case "g":
            //            case "j":
            //                //player.LeaveItem(input, gameWorld);
            //                break;

            //            case "i":
            //                InventoryManager im = new InventoryManager();
            //                im.DisplayInventory(player);
            //                break;
            //        }
            //    }
            //    while (running);
        }

        public static string GetInput()
        {
            return Console.ReadKey(true).KeyChar.ToString();
        }
    }
}
