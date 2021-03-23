using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine());

            int[,] mat = new int[quantidade, quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < quantidade; j++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine("Principal diagonal: ");

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            int contador = 0;
            string numeros = "";
            for (int i = 0; i < quantidade; i++)
            {
                for (int j = 0; j < quantidade; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        numeros = numeros + " " + mat[i, j];
                        contador++;
                    }
                }
            }
            Console.WriteLine(contador + " números negativos: " + numeros);
        }
    }
}
