using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hány alkalommal legyen feldobás?");
            double dobasok = double.Parse(Console.ReadLine());

            Random rand = new Random();
            int M = 0;

            int Anni = 0;
            int Panni = 0;

            while (M < dobasok)
            {
                int dob1 = rand.Next(1, 6);
                int dob2 = rand.Next(1, 6);
                int dob3 = rand.Next(1, 6);

                int dobossz = dob1 + dob2 + dob3;
                Console.Write($"Dobás: {dob1} + {dob2} + {dob3} = {dobossz}");

                if (dobossz < 10)
                {
                    Console.WriteLine("     Nyert: Anni");
                    Anni++;
                }
                else if (dobossz > 10)
                {
                    Console.WriteLine("     Nyert: Panni");
                    Panni++;
                }
                else
                {
                    Console.WriteLine("     Nyert: Panni");
                    Panni++;
                }
                M++;

            }

            Console.WriteLine($"A játék során {Anni} alkalommal Anni, {Panni} alkalommal Panni nyert.");

        }
    }
}
