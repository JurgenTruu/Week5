﻿using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt kolme numbrit
            //programm kuvab nende numbrite summat
            int sum = 0;
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Sisesta number:");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                sum = sum + userNumber;
            }
            Console.WriteLine($"Your total is: {sum}");
        }


    }
}