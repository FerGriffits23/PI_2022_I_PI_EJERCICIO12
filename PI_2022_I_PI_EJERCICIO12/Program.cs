using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_PI_EJERCICIO12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ciclos inciertos

            int numero;
            Console.WriteLine("Escriba un numero");
            numero = int.Parse(Console.ReadLine());

            while ((numero >20) || (numero<20))
            {
                Console.WriteLine("ingrese un numero");
                numero = int.Parse(Console.ReadLine());
            }

            Console.ReadLine();


        }
    }
}
