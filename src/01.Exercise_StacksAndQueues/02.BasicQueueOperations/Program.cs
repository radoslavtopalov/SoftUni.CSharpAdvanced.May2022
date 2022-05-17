using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var n = int.Parse(input[0]);
            var numberToPopOut = int.Parse(input[1]);
            var lookFor = int.Parse(input[2]);

            var queue = new Queue<int>();

            var input2 = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (var i = 0; i < n; i++)
            {
                queue.Enqueue(int.Parse(input2[i]));
            }

            for (var i = 0; i < numberToPopOut; i++)
            {
                queue.TryDequeue(out _);
            }

            if (queue.Contains(lookFor))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Count == 0 ? 0 : queue.Min());
            }
        }
    }
}