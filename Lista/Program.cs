using System;
using System.Collections.Generic;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Insert(0, "Marco");
            list.Add("Alex");
            list.Insert(1, "Anna");
            list.Add("André");
            list.Add("José");
            list.Add("Carlos");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List.Count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeira ocorrencia de nome com a primeira letra A: " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Ultima ocorrencia de nome iniciado com a letra A: " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira posição de quem começa com A: " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira posição de quem começa com A: " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("-------------");

            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            list.Remove("Alex");
            Console.WriteLine("-------------");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("-------------");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAt(1);
            Console.WriteLine("-------------");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAt(1);

            list.RemoveRange(0, 1);
            Console.WriteLine("-------------");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
