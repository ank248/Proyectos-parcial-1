using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patata
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            char operador;
            double num1, num2, resultado;

            //operación solicitada
            Console.Write("Ingrese la operación (+, -, *, /): ");
            operador = Convert.ToChar(Console.ReadLine());

            //primer numero
            Console.Write("Ingrese el primer numero: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            //segundo numero
            Console.Write("Ingrese el segundo numero: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            //operación
            switch (operador)
            {
                //suma
                case '+':
                    resultado = num1 + num2;
                    break;

                //resta
                case '-':
                    resultado = num1 - num2;
                    break;

                //multiplicación
                case '*':
                    resultado = num1 * num2;
                    break;

                //división
                case '/':
                    //verificar que el divisor no es 0
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error no se puede dividir entre cero.");
                        return; //salir del programa
                    }
                    break;
                default:
                    Console.WriteLine("Error: Operador no valido.");
                    return;
            }
            //resultado
            Console.WriteLine("Resultado: " + resultado);

        }
    }
}
