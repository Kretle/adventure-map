using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace algorithmic_design
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Map(50, 15);
        }
        static void Map(int width, int height)
        {
            var quarterOfMap = width / 4;
            var random = new Random();
            var treeSymbols = "ATX/Y";
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    // border
                    if (x == 0 && y == 0 || x == width-1 && y == 0 || x == 0 && y == height-1 || x == width-1 && y == height-1)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("+");
                        continue;
                    }
                    if (x == width-1 || x == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("|");
                        continue;
                    }
                    if (y == height-1 || y == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("-");
                        continue;
                    }
                    //forest
                    if (x < random.Next(0, quarterOfMap))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(treeSymbols[random.Next(treeSymbols.Length)]);
                        continue;
                    }
                    
                        // width / 4
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
