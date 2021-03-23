//Programa exemplificando algumas funcionalidades de uma matriz
//A Matriz deste exercício terá o mesmo número de linhas e colunas

using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recebe a quantidade de linhas e colunas que a matriz terá
            int quantidade = int.Parse(Console.ReadLine());

            //Cria e instancia a Matriz passando a quantidade lida anteriormente como a quantidade
            //de linhas e colunas
            int[,] mat = new int[quantidade, quantidade];

            //Loop para percorrer as linhas
            for (int i = 0; i < quantidade; i++)
            {
                //Vetor para armazenar os números informados em uma linha
                string[] valores = Console.ReadLine().Split(' ');

                //Loop para percorrer as colunas
                for (int j = 0; j < quantidade; j++)
                {   
                    //Armazena os números do vetor nas colunas de cada linha
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine("Principal diagonal: ");

            //Exibe os números na coluna principal, ou seja, na direção diagonal da matriz
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            int contador = 0;
            string numeros = "";
            //Loop para percorrer novamente as linhas
            for (int i = 0; i < quantidade; i++)
            {
                //Loop para percorrer novamente as colunas
                for (int j = 0; j < quantidade; j++)
                {
                    //Verifica se o número é negativo, se veradadeiro adiciona a string e ao contador para
                    //ser impresso futuramente
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
