namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                decimal salario = 0;
                decimal vendas = 0;
                decimal percentual = 0;
                Console.WriteLine("______________________");
                Console.WriteLine("Insira: seu salário base, o total de vendas e o % de sua comissão:");
                Console.WriteLine("_______________________\n");
                string[] entrada = Console.ReadLine()!.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (entrada.Length == 3 &&
                    decimal.TryParse(entrada[0].Trim(), out salario) &&
                    decimal.TryParse(entrada[1].Trim(), out vendas) &&
                    decimal.TryParse(entrada[2].Trim(), out percentual))
                {
                    decimal calcComissao = (percentual / 100) * vendas;
                    decimal salarioTotal = calcComissao + salario;
                    Console.WriteLine($"sua comissão é de {calcComissao} totalizando {salarioTotal:F2}");
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