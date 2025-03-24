namespace exercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Tabuada de um número");
            Console.WriteLine("---------------------------------------------");

            int numero;

            Console.Write("Digite um número de 1 a 10: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero < 1 || numero > 10)
            {
                Console.WriteLine("Número inválido.");
            }
            else
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine($"{i} x {numero} = {i * numero}");
                }
            }

            Console.ReadLine();
        }
    }
}