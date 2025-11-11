using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {   

                //1. feladat - adatok megadása a kódban
                Console.WriteLine("1. feladat: adatok beolvasva");
                int[] uvegek = { 5, 2, 2, 4, 3, 2, 4, 10, 5, 5, 3, 5, 4, 3, 3 };

                //2. feladat - Lekvár mennyisége
                Console.WriteLine("2. feladat:");
                int L = int.Parse(Console.ReadLine());
                Console.WriteLine($"Mari néni lekvárja (dl): {L}");
                
                //3. feladat - Legnagyobb üveg
                Console.WriteLine("3. feladat:");
                int maxErtek = uvegek.Max();
                int elsoIndex = Array.IndexOf(uvegek, maxErtek) + 1; // +1, mert sorszám
                Console.WriteLine($"A legnagyobb üveg: {maxErtek} dl és {elsoIndex}. a sorban.");

                //4. feladat - elegendő üveg?
                Console.WriteLine("4. feladat:");
                int osszKapacitas = uvegek.Sum();
                if (osszKapacitas >= L)
                {
                    Console.WriteLine("Elegendő üveg volt.");
                }
                else
                {
                    Console.WriteLine("Maradt lekvár.");
                }
                
            }
        }
    }
}
