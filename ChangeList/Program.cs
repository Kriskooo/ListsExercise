using System;
using System.Collections.Generic;
using System.Linq;
namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> command = Console.ReadLine().Split(' ').ToList();
            while (command[0] != "end")
            {
                if (command[0] == "Delete")
                {
                    numbers.RemoveAll(item => item == int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }
                command.Clear();
                command = Console.ReadLine().Split(' ').ToList();
            }
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
