using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMultiplica2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingrese el primer número:");
                int numero1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo número:");
                int numero2 = int.Parse(Console.ReadLine());

                int resultado = Multiplicar(numero1, numero2);

                Console.WriteLine("Resultado: " + resultado);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.ReadLine();
            }
        }

        static int Multiplicar(int a, int b)
        {
            int resultado = 0;
            int positivo = Math.Abs(b);

            for (int i = 0; i < positivo; i++)
            {
                resultado += a;
            }

            if (b < 0)
            {
                resultado = -resultado;
            }

            return resultado;
        }
    }
}
