namespace Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, resultado;

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Calculadora de Soma e Multiplicação");
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("Digite o valor de A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                resultado = a + b;
            }
            else
            {
                resultado = a * b;
            }

            Console.WriteLine($"O valor de C é: {resultado}");

            Console.ReadLine();
        }
    }
}
