namespace exercicio22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Sequência de Fibonacci");
            Console.WriteLine("---------------------------------------------");

            int numero;
            int a = 0;
            int b = 1;
            int c = 0;

            Console.Write("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a);
            Console.WriteLine(b);

            while (c < numero)
            {
                c = a + b;
                if (c <= numero)
                {
                    Console.WriteLine(c);
                }
                a = b;
                b = c;
            }

            Console.ReadLine();
        }
    }
}