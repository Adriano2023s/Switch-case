using System;

namespace Métodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool loopMenu = true;

            while (loopMenu)
            {
                Console.WriteLine("Atividades de Switch case com métodos para revizão.");
                Console.WriteLine("Escolha uma opção \n");
                Console.WriteLine("Opção 1: Atividade verificador de números impares e pares.");
                Console.WriteLine("Opção 2: Atividade coordenadas");
                Console.WriteLine("opção 3: Atividade intervalos de números.");
                int menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        ProgramaVerificador();
                        break;
                        case 2:
                        Coordenada();
                        break;
                }
            }
        }

        public static void ProgramaVerificador()
        {
            Console.WriteLine("Atividade 1:");

            int numero;

            Console.WriteLine("Digite um número para fazer a verificação.");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine($"O número: {numero}, é par");
            }
            else
            {
                Console.WriteLine($"O número: {numero}, é impar");
            }
        }

public static void Coordenada()
        {
            Console.WriteLine("Atividade 2:");

            double x;
            double y;

            while (true)
            {
                Console.WriteLine("Digite o valor de x:");
                x = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor de y:");
                y = double.Parse(Console.ReadLine());

                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro quadrante");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Segundo quadrante");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Terceiro quadrante");
                }
                else
                {
                    Console.WriteLine("Quarto quadrante");
                    break;
                }
            }
        }

    }
}
