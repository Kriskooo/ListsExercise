using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var splittedInput = input.Split('|').ToList();

            splittedInput.Reverse();
            var output = new List<List<int>>();

            for (int i = 0; i < splittedInput.Count; i++)
            {
                var intArray = splittedInput[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                output.Add(intArray);
            }

            for (int i = 0; i < output.Count; i++)
            {
                for (int j = 0; j < output[i].Count; j++)
                {
                    Console.Write(output[i][j] + " ");
                }
            }
        }
    }
}

