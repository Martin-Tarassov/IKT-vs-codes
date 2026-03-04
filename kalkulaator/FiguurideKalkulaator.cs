using System;

class Program
{   
    static void Main(string[] args)
    {
        Console.WriteLine("1 - Ristkülik");
        Console.WriteLine("2 - Ruut");
        Console.WriteLine("3 - Kolmnurk");
        Console.WriteLine("4 - Ring");
        Console.Write("Valik: ");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.Write("Pikkus: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Laius: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double S = a * b;
            double P = 2 * (a + b);

            Console.WriteLine("Pindala = " + S.ToString("F2"));
            Console.WriteLine("Ümbermõõt = " + P.ToString("F2"));
        }
        else if (choice == "2")
        {
            Console.Write("Külg: ");
            double a = Convert.ToDouble(Console.ReadLine());

            double S = a * a;
            double P = 4 * a;

            Console.WriteLine("Pindala = " + S.ToString("F2"));
            Console.WriteLine("Ümbermõõt = " + P.ToString("F2"));
        }
        else if (choice == "3")
        {
            Console.Write("Külg a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Külg b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Külg c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kõrgus küljele a: ");
            double h = Convert.ToDouble(Console.ReadLine());

            double S = a * h / 2;
            double P = a + b + c;

            Console.WriteLine("Pindala = " + S.ToString("F2"));
            Console.WriteLine("Ümbermõõt = " + P.ToString("F2"));
        }
        else if (choice == "4")
        {
            Console.Write("Raadius: ");
            double r = Convert.ToDouble(Console.ReadLine());

            double S = Math.PI * r * r;
            double C = 2 * Math.PI * r;

            Console.WriteLine("Pindala = " + S.ToString("F2"));
            Console.WriteLine("Ümbermõõdu pikkus = " + C.ToString("F2"));
        }
        else
        {
            Console.WriteLine("Viga");
        }        
    }
}
