using System;
using System.Collections.Generic;
using System.Globalization;

namespace RegistroFuncionario
{
    class Principal
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários deseja adicionar? ");
            int quantidade = int.Parse(Console.ReadLine());

            List<Funcionario> funcionario = new List<Funcionario>();

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine("Funcionário #" + i + ":");

                Console.Write("Informe o ID do Funcionário: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Informe o nome do Funcionário: ");
                string nome = Console.ReadLine();

                Console.Write("informe o Salário deste funcionário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionario.Add(new Funcionario(id, nome, salario));
            }

            Console.Write("Informe o ID do funcionário que deseja aumentar o salário: ");
            int buscarId = int.Parse(Console.ReadLine());

            Funcionario emp = funcionario.Find(x => x.Id == buscarId);
            if (emp != null)
            {
                Console.WriteLine("Informe o percentual que será aumentado: ");
                double percentual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.AlteraSalario(percentual);
            }
            else
            {
                Console.WriteLine("ID não encontrado!");
            }

            Console.WriteLine("==============================");
            Console.WriteLine("Lista de funcionários atualizados:");

            foreach (Funcionario obj in funcionario)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
