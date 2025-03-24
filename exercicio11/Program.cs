namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Calculadora de dias de vida");
            Console.WriteLine("---------------------------------------------");

            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine()!;
            Console.Write("Digite a sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine()!);

            Console.WriteLine($"{nome}, VOCÊ JÁ VIVEU {idade * 365} DIAS.");

            Console.ReadLine();
        }
    }
}