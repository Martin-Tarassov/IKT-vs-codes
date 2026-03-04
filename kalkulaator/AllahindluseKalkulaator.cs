using System;

namespace AllahindluseKalkulaator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Allahindluse kalkulaator ---");

            // Sisestame andmed
            Console.WriteLine("Sisesta toote hind:");
            float hind = float.Parse(Console.ReadLine());

            Console.WriteLine("Sisesta allahindluse protsent:");
            float protsent = float.Parse(Console.ReadLine());

            // Arvutamine
            float summa = (hind * protsent) / 100;
            float tulemus = hind - summa;

            // Tulemused
            Console.WriteLine("-------------------------");
            Console.WriteLine("Sääst: " + summa + " EUR");
            Console.WriteLine("Uus hind: " + tulemus + " EUR");

            Console.ReadLine();
        }
    }
}
