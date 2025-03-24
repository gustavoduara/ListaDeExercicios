namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma viagem. O programa deve solicitar ao usuário: [x]
            //● A quilometragem inicial do veículo no início da viagem.
            //● A quilometragem final ao término da viagem.
            //● A quantidade de combustível consumida durante a viagem (em litros).

            decimal kmInicial = 0, kmFinal = 0, combustivel = 0;
            while (true)
            {
                Console.WriteLine("_______________________________________________________________");
                Console.WriteLine("Insira A quilometragem inicial do veículo no início da viagem:  ");
                Console.WriteLine("          A quilometragem final ao término da viagem: ");
                Console.WriteLine("            A quantidade de combústivel connsumida: ");
                Console.WriteLine("_______________________________________________________________\n");
                string[] entrada = Console.ReadLine()!.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (entrada.Length == 3 &&
                    decimal.TryParse(entrada[0].Trim(), out kmInicial) &&
                    decimal.TryParse(entrada[1].Trim(), out kmFinal) &&
                    decimal.TryParse(entrada[2].Trim(), out combustivel))

                {
                    decimal resultado = (kmFinal - kmInicial) / combustivel;
                    Console.WriteLine("_______________________________________________________________");
                    Console.WriteLine($"         combustível gasto foi de: {resultado:F2} por KM");
                    Console.WriteLine("_______________________________________________________________");
                }
                else
                {
                    Console.WriteLine("Entrada inválida! Aperte ENTER e tente novamente.");
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