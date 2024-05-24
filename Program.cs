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
                Console.WriteLine("Opção 4: Programa que verifica a quantidade de abastecimentos em um posto.");
                int menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        ProgramaVerificador();
                        break;
                        case 2:
                        Coordenada();
                        break;
                        case 3:
                        VerificadorDeIntervalo();
                        break;
                        case 4:
                        ProgramaPosto();
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

        public static void VerificadorDeIntervalo()
        {
            Console.WriteLine("Atividade 3:");

            int n1;
            int n2;

            Console.WriteLine("Digite um número para fazer a verificação \n");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número para fazer a verificação \n");
            n2 = int.Parse(Console.ReadLine());

            for (int i = n1; i < n2; i++)
            {
                if (i >= 10 && i <= 20)
                {
                    Console.WriteLine($"In, dentro: {i}");
                }
                else
                {
                    Console.WriteLine($"Olt, fora: {i}");
                }
                            }
        }

        public static void ProgramaPosto()
        {
            Console.WriteLine("Atividade 4:");

            int tipoCombustivel = 0;
            int[] contagemCombustivel = new int[4];

            while (tipoCombustivel <= 4)
            {
                Console.WriteLine("Escolha um tipo de combustível \n");
                Console.WriteLine("Opção 1: Gasolina;");
                Console .WriteLine("Opção 2: Diesel;");
                Console.WriteLine("Opção 3: Alcool;");
                Console.WriteLine("Opção 4: GNV;");
                Console.WriteLine("Opção 5: Sair;");
                tipoCombustivel = int.Parse(Console.ReadLine());

                switch (tipoCombustivel)
                {
                    case 1:
                        contagemCombustivel[0]++;
                        Console.WriteLine($"O combustível escolhido foi: Gasolina; A quantidade foi: {contagemCombustivel[0]}");
                        break;

                        case 2:
                        contagemCombustivel[1]++;
                        Console.WriteLine($"O combustível escolhido foi: Diesel; E a quantidade foi: {contagemCombustivel[1]}");
                        break ;

                    case 3:
                        contagemCombustivel[2]++;
                        Console.WriteLine($"O combustível escolhido foi: Alcool; E a quantidade foi: {contagemCombustivel[2]}");
                        break;

                        case 4:
                        contagemCombustivel[3]++;
                        Console.WriteLine($"O combustível escolhido foi: GNV; E a quantidade foi: {contagemCombustivel[3]}");
                        break;

                        case 5:
                        Console.WriteLine("Obrigado pela sua preferência!");
                        break;
                }
            }
        }

    }
}
