using System;
using System.Collections.Generic;

namespace SkiShopConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lave en liste
            List<int> SkiListe = new List<int>();

            // Adding elements to List 
            SkiListe.Add(1);
            SkiListe.Add(2);
            SkiListe.Add(3);
            SkiListe.Add(4);
            SkiListe.Add(5);

            Console.WriteLine("Elements Present in List:\n");

            // Visning af elementer
            foreach (int k in SkiListe)
            {
                Console.WriteLine(k);
            }

          
        }
    }
}
