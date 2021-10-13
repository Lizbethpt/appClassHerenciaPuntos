using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appClassHerenciaPuntos
{
    class Program
    {
        static void Main(string[] args)

        {
            /* Punto2D a;
             a = new Punto2D(98, 76);
             Console.WriteLine(a.ToString());

             Punto a2;
             a2 = new Punto(7.8);
             Console.WriteLine(a2.ToString());*/

            Punto3D p3D1;
            p3D1 = new Punto3D(1, 1, 2);
            Console.WriteLine(p3D1.ToString());

            Punto3D p3D2;
            p3D2 = new Punto3D(2, 2, 3);
            Console.WriteLine(p3D2.ToString());

            double d = p3D1.Distancia(p3D2);
            Console.WriteLine("Distancia =" + d);
            Console.ReadKey();
        }

            

        }  



        
    }
}      
    

