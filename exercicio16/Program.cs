namespace Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Verificador de número par ou ímpar");
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número é par.");
            }
            else
            {
                Console.WriteLine("O número é ímpar.");
            }

            Console.ReadLine();
        }
    }
}