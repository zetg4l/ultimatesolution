﻿using System;
 
namespace MyUltimateSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Hi Pawel");
            for(int i=0;i<10;i++)
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine(rand.Next(100,999));
            }
        }
    }
}