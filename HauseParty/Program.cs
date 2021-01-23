using System;
using System.Collections.Generic;
using System.Linq;
namespace HauseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();
            for (int i = 0; i < num; i++)
            {
                int counter = 0;
                List<string> commands = Console.ReadLine().Split(' ').ToList();
                if (commands[1] == "is" && commands[2] == "going!")
                {
                    if (names.Contains(commands[0]))
                    {
                        Console.WriteLine($"{commands[0]} is already in the list!");
                        
                    }
                    else
                    {
                        names.Add(commands[0]);
                    }
                }
                else if (commands[1] == "is" && commands[2] == "not")
                {
                    if (!names.Contains(commands[0]) && counter < 1)
                    {
                        Console.WriteLine($"{commands[0]} is not in the list!");
                        counter++;                        
                    }
                    else if (names.Contains(commands[0]))
                    {
                        names.Remove(commands[0]);
                    }
                }
            }
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
