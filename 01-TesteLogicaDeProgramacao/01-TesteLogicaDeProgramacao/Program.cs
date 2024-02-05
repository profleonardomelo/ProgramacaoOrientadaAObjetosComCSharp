using System;
using System.Globalization;

namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n\nEscolha uma opção:");
                Console.WriteLine("1. Calcular o preço total das peças");
                Console.WriteLine("2. Calcular a área do círculo");
                Console.WriteLine("0. Sair\n");

                string? escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        q1_preco_total();
                        break;
                    case "2":
                        q2_calculo_area_circulo();
                        break;
                    case "0":
                        Console.WriteLine("Programa encerrado.");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        static void q1_preco_total()
        {
            Console.WriteLine("\nDigite os dados da primeira peça (formato: código quantidade valor):");
            string? linhaLida = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(linhaLida))
            {
                Console.WriteLine("Entrada inválida. Programa encerrado.");
                return;
            }

            string[] linhaLidaSplited = linhaLida.Split(" ");

            if (linhaLidaSplited.Length < 3)
            {
                Console.WriteLine("Formato de entrada inválido. Programa encerrado.");
                return;
            }

            int codigoDaPeca = Convert.ToInt32(linhaLidaSplited[0]);
            int quantidadeDeItensDaPeca = Convert.ToInt32(linhaLidaSplited[1]);
            double valorUnitarioDaPeca = Convert.ToDouble(linhaLidaSplited[2], CultureInfo.InvariantCulture);

            Console.WriteLine("\nDigite os dados da segunda peça (formato: código quantidade valor):");
            string? linhaLida2 = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(linhaLida2))
            {
                Console.WriteLine("Entrada inválida. Programa encerrado.");
                return;
            }

            string[] linhaLidaSplited2 = linhaLida2.Split(" ");

            if (linhaLidaSplited2.Length < 3)
            {
                Console.WriteLine("Formato de entrada inválido. Programa encerrado.");
                return;
            }

            int codigoDaPeca2 = Convert.ToInt32(linhaLidaSplited2[0]);
            int quantidadeDeItensDaPeca2 = Convert.ToInt32(linhaLidaSplited2[1]);
            double valorUnitarioDaPeca2 = Convert.ToDouble(linhaLidaSplited2[2], CultureInfo.InvariantCulture);

            double total = (quantidadeDeItensDaPeca * valorUnitarioDaPeca) + (quantidadeDeItensDaPeca2 * valorUnitarioDaPeca2);

            Console.WriteLine("\nValor a pagar R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }

        static void q2_calculo_area_circulo() 
        {
            Console.WriteLine("\nDigite o valor do raio do círculo:");

            string? strRaio = Console.ReadLine();

            double raio = Convert.ToDouble(strRaio, CultureInfo.InvariantCulture);

            double area = Math.PI * Math.Pow(raio, 2);

            Console.WriteLine("\nÁrea do círculo: " + area.ToString("F4", CultureInfo.InvariantCulture));
           
        }
    }
}
