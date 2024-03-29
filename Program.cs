﻿using System;
using System.Globalization;

namespace VectorExc1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            Product[] vect = new Product[n];
            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine());
                vect[i] = new Product { Name = nome, Price = preco };
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }

            double avg = sum / n;

            Console.WriteLine("AVERAGE PRICE IS = " + avg.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
