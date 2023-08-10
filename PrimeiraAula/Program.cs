using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraAula
{
    internal class Program
    {
        // Atributos
        // Metodos
        static void Main(string[] args)
        {
            // Algoritimo
            Console.Write("Hello World!");
            Console.WriteLine("Mais uma linha!");

            string nome = "Mara José";

            Console.WriteLine("O nome da pessoa: \n" + nome);

            Console.WriteLine("Entre com um novo nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("O nome da pessoa: " + nome);

            Console.WriteLine("Entre com um numero: ");
            int numero = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("O numero digitado foi:" + numero);

            Console.ReadKey();

        }
    }
}
