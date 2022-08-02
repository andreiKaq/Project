using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!!!!!!!!!");
            int num = 1000;
            Console.ForegroundColor = ConsoleColor.Green;
            

            for (int i = 0; i <= 1000; i++)
            {
                
                num = num - 7;

                Console.WriteLine(num);
                Thread.Sleep(30);
            }


        }
    }
}
