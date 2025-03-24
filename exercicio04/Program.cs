namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit
            decimal celsius = 0;
            while (true)
            {
                Console.WriteLine("_______________________________________________________________");
                Console.WriteLine("               Insira a Temperatura em Célsius: ");
                Console.WriteLine("_______________________________________________________________\n");
                string[] entrada = Console.ReadLine()!.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (entrada.Length == 1 &&
                    decimal.TryParse(entrada[0].Trim(), out celsius))

                {
                    decimal resultado = (celsius * (decimal)1.8) + 32;
                    Console.WriteLine("_______________________________________________________________");
                    Console.WriteLine($" {celsius} Celsius é equivalente a {resultado} Fahrenheit");
                    Console.WriteLine("_______________________________________________________________");
                }
                else
                {
                    Console.WriteLine("Entrada inválida! Aperte <ENTER> e tente novamente!");
                    Console.ReadLine();
                    continue;
                }
                Console.Write("Deseja continuar? (s/N): ");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();
                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}