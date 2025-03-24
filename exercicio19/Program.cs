namespace exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Soma de números ímpares múltiplos de 3 até 500");
            Console.WriteLine("---------------------------------------------");

            int soma = 0;
            for (int i = 1; i <= 500; i++)
            {
                if (i % 2 != 0 && i % 3 == 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine($"A soma dos números ímpares múltiplos de 3 até 500 é: {soma}");

            Console.ReadLine();
        }
    }
}