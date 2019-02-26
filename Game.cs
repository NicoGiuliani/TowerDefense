namespace TowerDefense
{
    class Game
    {
        static void Main(string[] args)
        {
            Map map = new Map(8, 5);
            int area = map.Width * map.Height;
            System.Console.Write($"The area of this map is {area} square units.");
            System.Console.ReadLine();
        }
    }
}
