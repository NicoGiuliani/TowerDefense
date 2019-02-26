using System;

namespace TowerDefense
{
    class Game
    {
        static void Main(string[] args)
        {
            Map map = new Map(8, 5);

            try
            {
                MapLocation point1 = new MapLocation(20, 23, map);
            }
            catch (Exception)
            {
                Console.WriteLine("That map location is not on the map.");
            }

            Console.ReadLine();

        }
    }
}
