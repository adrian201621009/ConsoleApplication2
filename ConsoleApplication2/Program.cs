using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
       
        
            static void Main(string[] args)
            {



                Console.WriteLine("que desea realizar: 1) area del trinagulo 2) area  de un circulo");
                int p = int.Parse(Console.ReadLine());

                Calcular r = new Calcular() { };
                if (p == 1) { r.Area(); }

                if (p == 2) { r.Circulo(); }

                Console.ReadKey();
            }


        }
    }


