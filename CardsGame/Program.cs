using System;
using System.Collections.Generic;
using System.Linq;
namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondPlayer = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            while (firstPlayer.Count != 0 && secondPlayer.Count != 0)
            {
                if (firstPlayer[0] > secondPlayer[0])
                {
                    int firstPlayerCards = firstPlayer[0];
                    int secondPlayerCards = secondPlayer[0];
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                    firstPlayer.Add(firstPlayerCards);
                    firstPlayer.Add(secondPlayerCards);
                }
                else if (secondPlayer[0] > firstPlayer[0])
                {
                    int secondPlayerCards = secondPlayer[0];
                    int firstPlayerCards = firstPlayer[0];
                    secondPlayer.RemoveAt(0);
                    firstPlayer.RemoveAt(0);
                    secondPlayer.Add(secondPlayerCards);
                    secondPlayer.Add(firstPlayerCards);
                }
                else if (secondPlayer[0] == firstPlayer[0])
                {
                    secondPlayer.RemoveAt(0);
                    firstPlayer.RemoveAt(0);
                }
            }
            if (firstPlayer.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayer.Sum()}");
            }
            else if (secondPlayer.Count > 0)
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayer.Sum()}");
            }
        }
    }
}
