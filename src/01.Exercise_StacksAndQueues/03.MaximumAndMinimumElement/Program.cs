using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumAndMinimumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var queriesCount = int.Parse(Console.ReadLine()!);

            var stack = new Stack<int>();

            for (var i = 0; i < queriesCount; i++)
            {
                var query = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                switch (int.Parse(query[0]))
                {
                    case 1:
                        stack.Push(int.Parse(query[1]));
                        break;
                    case 2:
                        stack.TryPop(out _);
                        break;
                    case 3:
                        if (stack.Count != 0)
                        {
                            Console.WriteLine(stack.Max());
                        }
                        break;
                    case 4:
                        if (stack.Count != 0)
                        {
                            Console.WriteLine(stack.Min());
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}