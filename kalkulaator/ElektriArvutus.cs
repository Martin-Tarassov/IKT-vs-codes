using System;

namespace ElektriArvutus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Elektri arvutamine ---");

            // Küsime palju vatte on
            Console.WriteLine("Mitu vatti (W) see on?");
            float vatid = float.Parse(Console.ReadLine());

            // Küsime tunde
            Console.WriteLine("Mitu tundi see paevas tootab?");
            float tunnid = float.Parse(Console.ReadLine());

            // Küsime hinda
            Console.WriteLine("Pane siia elektri hind (senti):");
            float hind = float.Parse(Console.ReadLine());

            // Arvutame vastuse
            float kwh = (vatid * tunnid * 30) / 1000;
            float raha = (kwh * hind) / 100;

            Console.WriteLine("--------------------------");
            Console.WriteLine("See maksab kuus: " + raha + " eurot");

            Console.ReadLine();
        }
    }
}
