using System;

namespace CollectorGame
{
    public class InventoryManager
    {
//        public void DisplayInventory(Player player)
//        {
//            bool running = true;
//            string input;

//            do
//            {
//                Console.Clear();
//                Console.WriteLine("Items:");
//                Console.WriteLine();

//                int i = 1;

//                foreach (IItem item in player.Inventory.ItemList)
//                {
//                    if (item.Quantity > 1)
//                        Console.WriteLine(" {2}. {0}s: {1}", item.Name, item.Quantity, i);
//                    else
//                        Console.WriteLine(" {1}. {0}", item.Name, i);

//                    i++;
//                }

//                Console.WriteLine();
//                if(!player.Inventory.EmptyHand)
//                    Console.WriteLine("Current selected item: {0}", player.Inventory.SelectedItem.Name);
//                Console.WriteLine();
//                Console.WriteLine("Press a number to select the corresponding item.");

//                input = MainGame.GetInput();

//                switch (input)
//                {
//                    case "i":
//                        running = false;
//                        break;

//                    case "1":
//                    case "2":
//                    case "3":
//                    case "4":
//                    case "5":
//                    case "6":
//                    case "7":
//                    case "8":
//                    case "9":
//                        int inputNumber = int.Parse(input);

//                        player.Inventory.SelectItemByNumber(inputNumber);
//                        break;
//                }
//            }
//            while (running);
//        }
    }
}
