using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program Animales = new Program();
            Console.WriteLine("Aves: "+Animales.Aves());
            Console.WriteLine("Reptiles: "+Animales.Reptiles());
            Console.WriteLine("Mamiferos: "+Animales.Mamiferos());
            Console.WriteLine("Acuaticos: "+Animales.Acuaticos());
            Console.ReadKey();
        }
        string Aves()
        {
            return "Gaviota, Colibri, Tucanes, Aguila, Zopilotes, Tortolas";
        }
        string Reptiles()
        {
            return "Lagarto, Cocodrilo, Iguana, Camaelon";
        }
        string Mamiferos()
        {
            return "Leon, Tigre, Pantera, Elefante, Jaguar";
        }
        string Acuaticos()
        {
            return "Tiburon, Delfin, Orcas";
        }
    }

}
