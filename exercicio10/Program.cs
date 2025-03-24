namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia. Cada pãozinho custa R$ 0,12 e a broa custa R$ 1,50.Ao final do dia, o dono quer saber quanto arrecadou com a
            // venda dos pães e broas(juntos), e quanto deve guardar numa conta de poupança(10 % do total arrecadado). Você foi contratado para fazer os cálculos para o dono.Com base nestes fatos, faça um algoritmo para ler as
            // quantidades de pães e de broas, e depois calcular os dados solicitados. [x]

            while (true)
            {
                double paes = 0, broas = 0;
                Console.WriteLine("_________________________________________________");
                Console.WriteLine("       Insira os pães e as broas vendidas ");
                Console.WriteLine("_________________________________________________\n");
                string[] entrada = Console.ReadLine()!.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (entrada.Length == 2 &&
                    double.TryParse(entrada[0].Trim(), out paes) &&
                    double.TryParse(entrada[1].Trim(), out broas))
                {
                    paes = paes * 0.12;
                    broas = broas * 1.50;
                    double total = paes + broas;
                    double rendimento = total * 0.1;
                    Console.WriteLine("_________________________________________________");
                    Console.WriteLine($"   valor total de pães vendidos: R${paes}");
                    Console.WriteLine($"   valor total de broas vendidos: R${broas}");
                    Console.WriteLine($"   valor total somado: R${total}");
                    Console.WriteLine($"   valor para rendimento: R${rendimento:F2}");
                    Console.WriteLine("_________________________________________________\n");
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

