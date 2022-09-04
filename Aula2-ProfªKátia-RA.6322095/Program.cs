using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_ProfªKátia_RA._6322095
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Filme Filme = new Filme();
            Entrada entrada = new Entrada();

            Console.WriteLine("Digite o Titulo: ");
            string titulo = Console.ReadLine();

            Console.WriteLine("Digite a Sinopse: ");
            string sinopse = Console.ReadLine();

            Console.WriteLine("Digite o Gênero: ");
            string genero = Console.ReadLine();

            Console.WriteLine("Digite a Classificação: ");
            string clasificacao = (Console.ReadLine());

            Filme.Receber(titulo, sinopse, genero, clasificacao);

            Console.WriteLine("Digite o Valor: ");
            entrada.SetValor(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Digite a Poltrona: ");
            entrada.SetPoltrona(Console.ReadLine());

            Console.WriteLine("Digite a Data: ");
            entrada.SetData(Console.ReadLine());

            Console.WriteLine("Digite a Hora: ");
            entrada.SetHora(Console.ReadLine());

            Console.Clear();


            Console.WriteLine(Filme.Mostrar() + "\n\n" + "Valor: " + entrada.GetValor().ToString("C") + " Reais " +
            "\nPoltrona: " + entrada.GetPoltrona() + "\nData: " + entrada.GetData() + "\nHora: " + entrada.GetHora());
            Console.ReadKey();
        }
    }
}
        
