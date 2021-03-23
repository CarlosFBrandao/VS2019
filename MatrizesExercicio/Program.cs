using System;

namespace MatrizesExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de linhas e colunas da Matriz: ");

            string[] valores = Console.ReadLine().Split(' ');

            int linhas = int.Parse(valores[0]);
            int colunas = int.Parse(valores[1]);

            int[,] mat = new int[linhas, colunas];

            for (int i = 0; i < linhas; i++)
            {
                Console.WriteLine("Informe os números da linha: " + i);
                string[] numeros = Console.ReadLine().Split(' ');
                for (int j = 0; j < colunas; j++)
                {
                    mat[i, j] = int.Parse(numeros[j]);
                }
            }

            Console.Write("Informe o número que deseja buscar: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if (mat[i, j] == numero)
                    {
                        Console.WriteLine("Posição: " + i + ", " + j);
                        if (j > 0)
                        {
                            Console.WriteLine("Direita: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Encima: " + mat[i - 1, j]);
                        }
                        if (j < linhas - 1)
                        {
                            Console.WriteLine("Esquerda: " + mat[i, j + 1]);
                        }
                        if (i < colunas - 1)
                        {
                            Console.WriteLine("Embaixo: " + mat[i + 1, j]);
                        }
                    }
                }
            }

        }
    }
}
