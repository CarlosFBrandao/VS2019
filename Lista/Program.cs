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

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List.Count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeira ocorrencia de nome com a primeira letra A: " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Ultima ocorrencia de nome iniciado com a letra A: " + s2);
        }
    }
}
