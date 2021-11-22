using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2, deltaAoQuadrado;

            Console.WriteLine("O nosso programa irá calcular o valor de 'x' apartir de uma equação de 2º incompleta" +
                "(ax² + bx + c = 0). E para isso iremos utilizar a fórmula de Bháskara.");

            Console.WriteLine("Para começar será necessário que nos informe o valor de 'a':");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Agora o valor de 'b':");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("E por último o valor de 'c':");
            c = Convert.ToDouble(Console.ReadLine());

            // Aplicando a fórmula de bháskara
            delta = (b * b) - (4 * a * c);
            deltaAoQuadrado = Math.Sqrt(delta);

            Console.WriteLine(deltaAoQuadrado);
            
            x1 = (-b + deltaAoQuadrado) / (2 * a);
            x2 = (-b - deltaAoQuadrado) / (2 * a);

            if (delta < 0)
            {
                Console.WriteLine("O delta é negativo. Equação não possui raízes reais");
            }
            if(a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("Multiplicação por 0. Equação não possui raízes reais");
            }
            else
            {
                Console.WriteLine("X1 = " + Math.Round(x1, 5) +
                                  "\nX2 = " + Math.Round(x2, 5));
            }

            Console.ReadLine();
        }
    }
}
