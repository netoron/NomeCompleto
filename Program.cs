using System;

namespace NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu Primeiro Nome");
            String primeiro = Console.ReadLine();
            Console.WriteLine("Digite seu Segundo Nome");
            String Segundo = Console.ReadLine();
            Console.WriteLine("Nome completo"); 
            string Dois = primeiro + " " + Segundo;
            Console.WriteLine(Dois);
            Console.WriteLine("Nome de catálogo");
            string tres = Segundo + " " + primeiro;
            Console.WriteLine(tres);
        }
    }
}
