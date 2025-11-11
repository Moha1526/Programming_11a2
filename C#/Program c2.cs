using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2
{
    internal class Program
    {
        static void Main(string[] args)
        /*
    {
        Console.WriteLine("Téglalap kerülete és területe");
        Console.WriteLine("Kérem az a oldalt:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Kérem a b oldalt:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("A kerület:"+2*a+2*b);
        double ker = 2 * a + 2 * b;
        double ter = a * b;
        Console.WriteLine($"A terület: {ter}");
        if (ker==ter)
        {
            Console.WriteLine("Egyenlő!");
        }
        else if (ker>ter)
        {
            Console.WriteLine("A kerület a nagyobb!");
        }
        else
        {
            Console.WriteLine("A terület a nagyobb!");
        }

    }
    */

        /*
            {
                Random rnd = new Random();

                Console.WriteLine("Tanár-diák kockajáték");
                int tanar = rnd.Next(1, 6);
                Console.WriteLine($"A tanár {tanar} dobott!");
                int diak = rnd.Next(1, 6);
                Console.WriteLine($"A diák {diak} dobott!");
                if (tanar==diak)
                {
                    Console.WriteLine("Egyenlő!");
                }
                else if (tanar>diak)
                {
                    Console.WriteLine("A tanár nyert!");
                }
                else
                {
                    Console.WriteLine("A diák nyert!");
                }
        */
        /*
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            for (int i=1; i<=5; i++)
            {
                Console.WriteLine("Hajrá ZTE!");
            }
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Fúj Újpest!");
            }
        */

        /*
        {
            string[] nevek = { "Anna", "Béla", "Csaba" };
                
                for (int i=0; i<nevek.Length; i++)
                {
                    Console.WriteLine(nevek[i]);
                }
        }
        */
        /*
        {
            string[] nevek = { "Dániel", "Elek", "Éva" };
            foreach (string nev in nevek)
            {
                Console.WriteLine(nev);
            }
        }
        */
        /*
        {
            int i = 0;
            while (i<5)
            {
                Console.WriteLine(i);
                i++;
            }
        */
        /*
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);
        }
        */
        /* Minek:
        {
            int[] szamok = { 12, 5, 8, -3, 15, 0 };
            //kezdő minimum az első elem
            int min = szamok[0];

            //végigmegyünk a tömön for ciklussal
            for (int i = 1; i < szamok.Length;i++)
            {
                if (szamok[i]<min)
                {
                    min = szamok[i];
                }
            }

            Console.WriteLine("A legkisebb szám:" + min);
        }
        */
        /*
        {
            int[] szamok = { 12, 5, 8, -3, 15, 0 };
            //kezdő minimum az első elem
            int min = szamok[0];
            
            //foreach ciklus minden elemen végigmegy
            foreach (int szam in szamok)
            {
                if (szam<min)
                {
                    min = szam;
                }
            }

            Console.WriteLine("A legkisebb szám:" + min);
        }
        */
        /*
        {
            int[] szamok = { 12, 5, 8, -3, 15, 0 };
            //kezdő minimum az első elem
            int min = szamok[0];

            int i = 1; //a 0. elemet már betettük a min-be
            while (i<szamok.Length)
            {
                if (szamok[i]<min)
                {
                    min = szamok[i];
                }
                i++;
            }

            Console.WriteLine("A legkisebb szám:" + min);
        }
        */
        /*
        {
            int[] szamok = { 12, 5, 8, -3, 15, 0 };
       
            int min = szamok[0]; //kezdő minimum az első elem

            int i = 1; //a 0. elemet már betettük a min-be
            do
            {
                if (szamok[i] < min)
                {
                    min = szamok[i];
                }
                i++;
            }
            while (i < szamok.Length);

            Console.WriteLine("A legkisebb szám:" + min);
        }
        */
        /*
        {
            int[] szamok = { 12, 5, 8, -3, 15, 0 };

            int min = szamok.Min();
            Console.WriteLine($"A legkisebb szám: {min}.");


        }
        */
        /* Maxok:
        {
            int[] szamok = { 12, 5, 8, -3, 15, 0 };

            int max = szamok[0];

            for (int i=1; i<szamok.Length; i++)
            {
                if (szamok[i]>max)
                {
                    max = szamok[i];
                }
            }

            Console.WriteLine($"A legnagyobb szám: {max}.");
        }
        */
        /*
        {
            int[] szamok = { 12, 5, 8, -3, 15, 0 };

            int max = szamok[0];

            foreach (int szam in szamok)
            {
                if (szam>max)
                {
                    max = szam;
                }
            }

            Console.WriteLine($"A legnagyobb szám: {max}.");
        }
        */
        /*
        {
            int[] szamok = { 12, 5, 8, -3, 15, 0 };

            int max = szamok[0];

            int i = 1;
            while (i<szamok.Length)
            {
                if (szamok[i]>max)
                {
                    max = szamok[i];
                }
                i++;
            }

            Console.WriteLine($"A legnagyobb szám: {max}.");
        }
        */
        /*
        {
            int[] szamok = { 12, 5, 8, -3, 15, 0 };

            int max = szamok[0];

            int i = 1;
            do
            {
                if (szamok[i] > max)
                {
                    max = szamok[i];
                }
                i++;
            }
            while (i < szamok.Length);

            Console.WriteLine($"A legnagyobb szám: {max}.");
        }
        */
        /*
        {
            int[] szamok = { 12, 5, 8, -3, 15, 0 };

            int max = szamok.Max();

            Console.WriteLine($"A legnagyobb szám: {max}");
        }
        */
        {
            List<int> szamok = new List<int> { 4, 8, 15, 16, 23, 42 };
            int keresett = 16;
            bool megtalalva = false;

            for (int i=0; i<szamok.Count; i++)
            {
                if (szamok[i]==keresett)
                {
                    Console.WriteLine($"A keresett szám ({keresett}) megtalálva a(z) {i} indexen.")
                    megtalalva = true;
                    break; //kilépünk, mert megtaláltuk
                }
            }

            if (!megtalalva)
            {
                Console.WriteLine($"A {keresett} szám nincs a listában.");
            }
        }
    }
}
