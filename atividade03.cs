using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;

            int[] numeros = new int[3];

            Console.WriteLine("Digite o primeiro número: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o primeiro segundo: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o primeiro terceiro: ");
            n3 = Convert.ToInt32(Console.ReadLine());

            numeros[0] = n1;
            numeros[1] = n2;
            numeros[2] = n3;

            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine(n1 + " Foi o maior número digitado");
            }
            else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine(n2 + " Foi o maior número digitado");
            }
            else {
                Console.WriteLine(n3 + " Foi o maior número digitado");
            }

            Array.Sort(numeros);
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.ReadKey();
        }
    }
}
