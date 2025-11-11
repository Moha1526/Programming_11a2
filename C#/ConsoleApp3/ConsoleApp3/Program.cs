using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            {
                //Tömb létrehozása...

                //5 elemű int tömb létrehozása
                int[] szamok = new int[5];

                //Értékadás
                szamok[0] = 10;
                szamok[1] = 20;

                //Inicializálás egyből
                int[] szamok2 = { 1, 2, 3, 4, 5 };
                Console.WriteLine(szamok2[1]);
                Console.WriteLine(string.Join(",", szamok2));
                Console.WriteLine(szamok.GetType());
            }
            */
            /*
            {
                //Lista létrehozása

                //Üres lista létrehozása
                List<int> szamok3 = new List<int>();

                //Elem hozzáadása
                szamok3.Add(10);
                szamok3.Add(20);

                //Inicializálás elemekkel
                List<int> szamok4 = new List<int> { 1, 2, 3, 4, 5, 6, 7, };
                Console.WriteLine(szamok4[0]);
                Console.WriteLine(string.Join(",",szamok4));
                Console.WriteLine(szamok4.GetType());
            }
            */
            /*
            {
                //Legnagyobb elem kiválasztása

                int[] szamok2 = { 1, 12, 3, 4, 5, 9 };
                int max1 = szamok2.Max();
                int max2 = szamok2[0];

                foreach (int szam in szamok2)
                {
                    if (szam>max2)
                    {
                        max2 = szam;
                    }
                }

                Console.WriteLine(max1);
                Console.WriteLine(max2);
            }
            */
            /*
            {
                //Összeg kiszámolása

                int[] szamok2 = { 1, 12, 3, 4, 5, 9 };
                int sum1 = szamok2.Sum();
                int sum2 = 0;

                foreach (int szam in szamok2)
                {
                    sum2 += szam;
                }

                Console.WriteLine(sum1);
                Console.WriteLine(sum2);
            }
            */
        }
    }
}
