using System;

namespace RobotNavigation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Application for the Robot navigation on Mars terrain");
            Console.WriteLine("****************************************************");

            Console.WriteLine("Please Enter the grid size");
            var gridSize = Console.ReadLine();

            Console.WriteLine("Please Enter the commands");
            var commands = Console.ReadLine();
            var manager = new Manager();
            var result = manager.Navigation(gridSize, commands);

            Console.WriteLine("Final X Position is: " + result.XPosition);
            Console.WriteLine("Final Y Position is: " + result.YPosition);
            Console.WriteLine("Final facing Direction is: " + result.Direction);
        }
    }
}
