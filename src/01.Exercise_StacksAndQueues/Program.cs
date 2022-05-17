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

            var stack = new Stack<int>();

            var input2 = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (var i = 0; i < n; i++)
            {
                stack.Push(int.Parse(input2[i]));
            }

            for (int i = 0; i < numberToPopOut; i++)
            {
                stack.TryPop(out _);
            }

            if (stack.Contains(lookFor))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Count == 0 ? 0 : stack.Min());
            }
        }
    }
}