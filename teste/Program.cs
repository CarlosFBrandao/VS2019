using System;
using System.Collections.Generic;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Informe o número da posição " + i);
                list.Add(int.Parse(Console.ReadLine()));
            }
            foreach(int obj in list){
                Console.WriteLine(obj);
            }
        }
    }
}
