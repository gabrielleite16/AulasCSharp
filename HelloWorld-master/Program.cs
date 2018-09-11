using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04092018
{
    class Program
    {

        static int Soma(int valor1, int valor2)
        {
            return valor1 + valor2;
        }

        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            Pessoa pessoa2 = new Pessoa("14523750629", "Gabriel Leite");

            Console.WriteLine(pessoa2.NomeCPF());

            int resultado = Soma(12, 15); 

            Console.WriteLine("\n\n\nPressione qualquer tecla para sair...");
            Console.ReadKey(true);

        }
    }
}
