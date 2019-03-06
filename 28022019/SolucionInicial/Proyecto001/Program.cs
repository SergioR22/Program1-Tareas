using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Se desea crear un programa que me permita imprimeir metodos que contengan el nombre, Apellido de una persona de forma separada
// y tambien debera imprimir su estatura y edad
namespace Proyecto001
{
    class Program
    {
        public int ValorA, ValorB;
        private int ValorC;
        static void Main(string[] args)
        {
            Program tec = new Program();
           Console.WriteLine(tec.Nombre1()+tec.Apellido1()+tec.edad());
            Console.ReadKey();
        }
           string Nombre1()
           {
               return "Sergio";
           }
            string Apellido1()
           {
               return "Rodriguez";
           }
            int edad()
           {
               return 28;
           }

        }
    }

