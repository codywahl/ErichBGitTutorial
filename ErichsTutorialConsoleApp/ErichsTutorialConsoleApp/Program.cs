﻿using System;

namespace ErichsTutorialConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Konnichiwa!");
			
            var i = 0;

            do
            {
                Console.WriteLine(i.ToString());
                i++;
            }
            while (i < 10);
            
            Console.ReadKey();
        }
    }
}