using System;
using System.Collections.Generic;
using System.Linq;
namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> commands = Console.ReadLine().Split(' ').ToList();
            while (commands[0] != "End")
            {
                if (commands[0] == "Add")
                {
                    numbers.Add(int.Parse(commands[1]));
                }
                else if (commands[0] == "Insert")
                {
                    if (int.Parse(commands[2]) < 0 || int.Parse(commands[2]) > numbers.Count - 1)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                    numbers.Insert(int.Parse(commands[2]), int.Parse(commands[1]));                       
                    }
                }
                else if (commands[0] == "Remove")
                {
                    if (int.Parse(commands[1]) < 0 || int.Parse(commands[1]) > numbers.Count - 1)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(int.Parse(commands[1]));
                    }
                }
                else if (commands[1] == "left" || commands[1] == "right")
                {
                    if (commands[1] == "left")
                    {
                        int counter = 0;
                        while (counter != int.Parse(commands[2]))
                        {
                            int currNum = numbers[0];
                            numbers.RemoveAt(0);
                            numbers.Add(currNum);
                            counter++;
                        }
                    }
                    else if (commands[1] == "right")
                    {
                        int count = 0;
                        while (count != int.Parse(commands[2]))
                        {
                            count++;
                            int currNum = numbers[numbers.Count - 1];
                            numbers.RemoveAt(numbers.Count - 1);
                            numbers.Insert(0, currNum);
                        }
                    }
                }
                commands = Console.ReadLine().Split(' ').ToList();
            }
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
