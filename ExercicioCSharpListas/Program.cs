using System.Collections.Generic;
using System.Globalization;

namespace ExercicioCSharpListas
{
    class Program
    {
        public static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>();

            Console.WriteLine("Quantos funcionarios serão cadastrados? ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine("Funcionário #1: ");
                Console.WriteLine("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employees.Add(new Employee(id, name, salary));

            }

            Console.WriteLine("Informe o id do funcionário que terá aumento salarial: ");
            int idPesquisa = int.Parse(Console.ReadLine());

            Employee emp = employees.Find(x => x.Id == idPesquisa);

            if (emp != null)
            {
                Console.WriteLine("Informe a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.increaseSalary(porcentagem);

            }
            else
            {
                Console.WriteLine("Esse id não existe");

            }
            foreach (Employee obj in employees)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
