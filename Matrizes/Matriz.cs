using System;

namespace Matrizes
{
    class Matriz
    {
            Console.Write("Informe a quantidade de linhas e colunas da Matriz: ");

            string[] valores = Console.ReadLine().Split(' ');

            int linhas = int.Parse(valores[0]);
            int colunas = int.Parse(valores[1]);

            int[,] mat = new int[linhas, colunas];

            for (int i = 0; i < linhas; i++)
            {
                Console.WriteLine("Informe os números da " + i + "ª linha: ");
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
                        Console.Write("Posição: " + i + ", " + j);
                        if (mat[i - 1, j] != null)
                        {
                            Console.Write("Superior: " + (mat[i - 1, j]));
                        }
                        else if (mat[i, j - 1] != null)
                        {
                            Console.Write("Esquerda: " + (mat[i, j - 1]));
                        }
                        else if (mat[i, j + 1] != null)
                        {
                            Console.Write("Direita: " + (mat[i, j + 1]));
                        }
                        else if (mat[i + 1, j] != null)
                        {
                            Console.Write("Embaixo: " + (mat[i + 1, j]));
                        }
                    }
                }
            }
        
    }
}
