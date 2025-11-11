using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladatok_09._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            {
                //1. feladat - aktivitás bekérése
                Console.WriteLine("1. feladat:");
                Console.WriteLine("Adja meg az aktivitását:");
                string aktivitas = Console.ReadLine();

                //2. feladat - távolság kiszámítása
                int osszKm = 0;
                bool voltU = false, voltG = false, voltF = false, voltK = false;

                foreach (char c in aktivitas)
                {
                    switch (c)
                    {
                        case 'U': osszKm += 1; voltU = true; break; // úszás
                        case 'G': osszKm += 1; voltG = true; break; // gyaloglás
                        case 'F': osszKm += 2; voltF = true; break; // futás
                        case 'K': osszKm += 10; voltK = true; break; // kerékpár
                    }
                }
                Console.WriteLine("2. feladat:");
                Console.WriteLine("A felhasználó által megtett távolság: {0} km", osszKm);

                //3. feladat -jutalom számítás
                int jutalom = 0;
                if (voltU && voltG && voltF && voltK)
                {
                    jutalom = 10;
                    Console.WriteLine("3. feladat");
                    Console.WriteLine("Bravó! Jutalma még 10 km.");
                }
                else
                {
                    Console.WriteLine("3. feladat");
                    Console.WriteLine("Nem jár jutalom.");
                }

                //4. feladat - végső teljesítmény + kiértékelés
                int vegsoKm = osszKm + jutalom;
                Console.WriteLine("Eredménye: {0} km", vegsoKm);

                if (vegsoKm>=40)
                {
                    Console.WriteLine("Gratulálok, kihívás teljesítve!");
                }
                else
                {
                    Console.WriteLine("Legközelebb sikerül!");
                }
                
            }
            */
        }
    }
}
