using System;

namespace KutuseArvutaja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Kutuse Kalkulaator ---");

            // Küsime andmed 
            Console.Write("Sisesta vahemaa (km): ");
            double distants = Convert.ToDouble(Console.ReadLine());

            Console.Write("Sisesta keskmine kulu (l/100km): ");
            double kulu = Convert.ToDouble(Console.ReadLine());

            Console.Write("Sisesta kutuse hind (EUR/liiter): ");
            double hind = Convert.ToDouble(Console.ReadLine());

            // Arvutamine 
            // Valem: (distants / 100) * kulu
            double kokku_liitrid = (distants / 100) * kulu;
            double kokku_euro = kokku_liitrid * hind;

            // Vastus
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Sul on vaja: " + kokku_liitrid + " liitrit");
            Console.WriteLine("Kokku maksab: " + kokku_euro + " eurot");

           
            // 1 - Kasutaja sisestab numbrid: vahemaa, kütuse kulu ja hinna
            // 2 - Programm jagab vahemaa sajaga (100)
            // 3 - Siis programm korrutab tulemuse kütuse kuluga. Nüüd me teame, kui palju liitrit on vaja
            // 4 - Lõpuks programm korrutab liitrid ja hinna. Nüüd me teame, kui palju raha on vaja
           

        }
    }
}