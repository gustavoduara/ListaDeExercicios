namespace exercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int fatorial = 1;

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Fatorial de um número");
            Console.WriteLine("---------------------------------------------");

            Console.Write("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = numero; i > 0; i--)
            {
                fatorial *= i;
            }

            Console.WriteLine($"O fatorial de {numero} é {fatorial}");

            Console.ReadLine();
        }
    }
}