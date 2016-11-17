using System;
using System.Collections.Generic;

namespace CollectorGame
{
    public static class Events
    {
        public static List<string> EventList = new List<string>();

        public static void Add(string message)
        {
            EventList.Add(message);
        }

        public static void DisplayEvents(int number)
        {
            if(EventList.Count >= number)
            {
                for(int i = 0; i < number; i++)
                {
                    Console.WriteLine("{0}", EventList[EventList.Count - number + i]);
                }
            }
            else
            {
                for (int i = 0; i < EventList.Count; i++)
                {
                    Console.WriteLine("{0}", EventList[i]);
                }
            }
        }
    }
}
