using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadorafi
{
    class Program
    {
        static void Main()
        {
            //variables
            char operacion, figura;
            double num1, num2, area, perimetro;

            Console.WriteLine("===============================");
            Console.WriteLine("¿Qué desea calcular?");
            Console.WriteLine("===============================");
            Console.WriteLine("1.- Area");
            Console.WriteLine("2.- Perimetro");
            Console.Write("-");
            operacion = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("===============================");
            
        }
    }
}
