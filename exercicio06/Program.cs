namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
            //  Crie um programa para calcular a média harmônica das notas de um Aluno [x]
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Quantas provas você fez?: ");
                Console.WriteLine("-----------------------------");
                string entrada = Console.ReadLine()!;
                if (!double.TryParse(entrada, out double quantProvas) || quantProvas <= 0)
                {
                    Console.WriteLine("erro");
                    return;
                }
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Insira-as");
                Console.WriteLine("-----------------------------");
                double[] notas = new double[(int)quantProvas];
                double somaInversos = 0;

                for (int i = 0; i < quantProvas; i++)
                {
                    Console.Write($"Nota {i + 1}: ");
                    notas[i] = Convert.ToDouble(Console.ReadLine());
                    somaInversos += 1 / notas[i];
                }
                double mediaHarmonica = quantProvas / somaInversos;
                Console.WriteLine($"{mediaHarmonica}");

                Console.Write("Deseja continuar? (s/N): ");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();
                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}