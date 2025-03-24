namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Verificador de soma");
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("Digite o valor de A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a + b < c)
            {
                Console.WriteLine("A soma de A + B é menor que C.");
            }
            else
            {
                Console.WriteLine("A soma de A + B não é menor que C.");
            }

            Console.ReadLine();
        }
    }
}