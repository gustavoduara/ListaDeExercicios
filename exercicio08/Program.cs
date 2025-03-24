namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8.Crie um programa para verificar se um número é primo.
            Console.WriteLine("digite um número: ");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                bool numeroPrimo = true;
                for (int i = 3; i * i <= numero; i++)
                {
                    if (numero % i == 0)
                        numeroPrimo = false;
                }
                if (numeroPrimo)
                    Console.WriteLine("O número é primo");
                else
                    Console.WriteLine("O número não é primo");
                Console.ReadLine();
            }
        }
    }
}