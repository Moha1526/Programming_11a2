using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            {
                List<int> szamok = new List<int> { 4, 8, 15, 16, 23, 42 };
                int keresett = 16;
                bool megtalalva = false;

                for (int i = 0; i < szamok.Count; i++)
                {
                    if (szamok[i] == keresett)
                    {
                        Console.WriteLine($"A keresett szám ({keresett}) megtalálva a(z) {i} indexen.");
                        megtalalva = true;
                        break; //kilépünk, mert megtaláltuk
                    }
                }

                if (!megtalalva)
                {
                    Console.WriteLine($"A {keresett} szám nincs a listában.");
                }
            }
            */
            /*
            {
                List<int> szamok = new List<int> { 4, 8, 15, 16, 23, 42 };
                int keresett = 16;
                bool megtalalva = false;
                int index = 0;

                foreach (int szam in szamok)
                {
                    if (szam == keresett)
                    {
                        Console.WriteLine($"A keresett szám ({keresett}) megtalálva a(z) {index} indexen.");
                        megtalalva = true;
                        break; //kilépünk, mert megtaláltuk
                    }
                    index++;
                }

                if (!megtalalva)
                {
                    Console.WriteLine($"A {keresett} szám nincs a listában.");
                }
            }
            */
            /*
            {
                List<int> szamok = new List<int> { 4, 8, 15, 16, 23, 42 };
                int keresett = 16;
                bool megtalalva = false;
                int i = 0;

                while (i<szamok.Count)
                {
                    if (szamok[i] == keresett)
                    {
                        Console.WriteLine($"A keresett szam ({keresett}) megtalalva a(z) {i} indexen.");
                        megtalalva = true;
                        break; //kilépünk, mert megtaláltuk
                    }
                    i++;
                }

                if (!megtalalva)
                {
                    Console.WriteLine($"A {keresett} szám nincs a listában.");
                }
            }
            */
            /*
            {
                List<int> szamok = new List<int> { 4, 8, 15, 16, 23, 42 };
                int keresett = 16;
                bool megtalalva = false;
                int i = 0;

                if (szamok.Count >0) //ellenőrizzük, hogy a lista ne legyen üres
                {
                    do
                    {
                        if (szamok[i] == keresett)
                        {
                            Console.WriteLine($"A keresett szám ({keresett}) megtalálva a(z) {i} indexen.");
                            megtalalva = true;
                            break; //kilépünk, mert megtaláltuk
                        }
                        i++;
                    } while (i < szamok.Count);
                }

                if (!megtalalva)
                {
                    Console.WriteLine($"A {keresett} szám nincs a listában.");
                }
            }
            */
            /*
            {
                List<int> szamok = new List<int> { 4, 8, 15, 16, 23, 42 };
                int keresett = 16;

                if (szamok.Contains(keresett))
                {
                    Console.WriteLine($"A keresett szám ({keresett}) megtalálva a listában.");
                }

                else
                {
                    Console.WriteLine($"A {keresett} szám nincs a listában.");
                }
            }
            */
            /*
            {
                List<int> szamok = new List<int> { 4, 8, 15, 16, 23, 42 };
                int keresett = 16;

                int index = szamok.Index0f(keresett);

                if (index!=-1)
                {
                    Console.WriteLine($"A keresett szám ({keresett}) megtalálva a(z) {index} indexen.");
                }

                else
                {
                    Console.WriteLine($"A {keresett} szám nincs a listában.");
                }
            }
            */
        }
    }
}
