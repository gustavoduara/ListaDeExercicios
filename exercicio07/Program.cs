namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //7.Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno
                Console.WriteLine("-----------------------------");
                Console.WriteLine(" Quantas provas você fez?: ");
                Console.WriteLine("-----------------------------");

                string entrada;
                int quantProvas;

                while (true)
                {
                    entrada = Console.ReadLine()!.Trim();
                    if (!int.TryParse(entrada, out quantProvas) || quantProvas <= 0)
                    {
                        Console.WriteLine("Insira um número válido");
                        Console.WriteLine("-----------------------");
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Insira as notas e os pesos de acordo com o requisitado");
                Console.WriteLine("------------------------------------------------------");
                int[] peso = new int[quantProvas];
                double[] notas = new double[quantProvas];

                for (int i = 0; i < quantProvas; i++)
                {
                    Console.Write($"Nota {i + 1}: ");
                    notas[i] = Convert.ToDouble(Console.ReadLine());
                    Console.Write($"peso {i + 1}: ");
                    peso[i] = Convert.ToInt32(Console.ReadLine());
                }

                double somaResultado = 0;
                double somaPesos = 0;

                for (int i = 0; i < quantProvas; i++)
                {
                    somaResultado += notas[i] * peso[i];
                    somaPesos += peso[i];
                }
                double newResultado = somaResultado / somaPesos;

                Console.WriteLine($"{newResultado}");

                Console.Write("Deseja continuar? (s/N): ");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();
                if (opcaoContinuar != "S")
                    break;


            }
        }
    }
}