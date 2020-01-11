using System;
using System.Collections.Generic;

namespace MarsRover
{
    class Program
    {
        private static readonly string[] RoversCommands = new string[2];
        static void Main(string[] args)
        {
            string input = "5 5\n1 2 N\nLMLMLMLMM\n3 3 E\nMMRMMRMRRM";
            input= args.Length != 0 ? args[0] : input;
            

            DeviceControl(input);
            foreach (var assignment in RoversCommands)
            {
                var marsRover = new MarsRover(assignment);
                marsRover.Initialize();
                marsRover.Navigate();
                Console.WriteLine(marsRover.FinalPosition);
            }
            Console.ReadLine();
        }

        private static void DeviceControl(string input)
        {
            try
            {
                var assignments = input.Split("\n", StringSplitOptions.RemoveEmptyEntries);
                RoversCommands[0] = assignments[0] + "\n" + assignments[1] + "\n" + assignments[2];
                RoversCommands[1] = assignments[0] + "\n" + assignments[3] + "\n" + assignments[4];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

    }
}
