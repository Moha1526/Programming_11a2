using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileel = @"C:\Users\info\Documents\Mohácsi Bálint 11A\C#\ut.txt";

            List<List<string>> hatarok = new List<List<string>>();

            using (StreamReader bemenet = new StreamReader(fileel))
            {
                int hossz = int.Parse(bemenet.ReadLine().Trim());

                string sor;
                while ((sor = bemenet.ReadLine()) != null)
                {
                    string[] reszek = sor.Trim().Split(' ');
                    // Az első elemet számra alakítjuk
                    reszek[0] = int.Parse(reszek[0]).ToString();

                    // Lista formában adjuk hozzá
                    hatarok.Add(new List<string>(reszek));
                }
            }
        }
    }
}
