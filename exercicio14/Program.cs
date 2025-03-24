namespace Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Ordenador de números");
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("Digite o valor de A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            c = Convert.ToInt32(Console.ReadLine());

            int[] numeros = { a, b, c };
            Array.Sort(numeros);

            Console.WriteLine($"Os números em ordem decrescente são: {numeros[2]}, {numeros[1]}, {numeros[0]}");

            Console.ReadLine();
        }
    }
}