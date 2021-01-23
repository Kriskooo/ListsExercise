using System;
using System.Collections.Generic;
using System.Linq;
namespace ListsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());
            List<string> command = Console.ReadLine().Split(' ').ToList();
            while (command[0] != "end")
            {
                if (command[0] == "Add")
                {
                    wagons.Add(int.Parse(command[1]));
                }
                else
                {
                    int number = int.Parse(command[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + number > capacity)
                        {                         
                        }
                        else
                        {
                            wagons[i] += number;
                            break;
                        }
                    }
                }
                command.Clear();
                command = Console.ReadLine().Split(' ').ToList();
            }
            Console.WriteLine(string.Join(' ', wagons));
        }
    }
}
