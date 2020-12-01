using System;
using System.Collections.Generic;
using System.Globalization;

/*Fazer um programa para ler os dados de N figuras (N é um
número fornecido pelo usuário), e depois mostrar as áreas
destas figuras na mesma ordem em que foram digitadas.*/
namespace POO_FormasGeometricas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Forma> lista = new List<Forma>();
            Console.WriteLine("Informe o número de formas: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Forma #{i}:");
                Console.Write("Retângulo ou Círculo (R/C)?");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Cor (Preto / Azul / Vermelho): ");
                Cor cor = Enum.Parse<Color>(Console.ReadLine());
                if (ch == 'R')
                {
                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new Retangulo(largura, altura, cor));
                }

                else
                {
                    Console.WriteLine("Raio: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new Circulo(raio, cor));
                }

                Console.WriteLine();
                Console.WriteLine("Área de cada forma: ");
                foreach (Forma forma in lista)
                {
                    Console.WriteLine(forma.Area().ToString("F2",CultureInfo.InvariantCulture)
                }



            }
            
        }
    }
}
