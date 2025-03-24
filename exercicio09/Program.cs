namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //9. A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um algoritmo para ler as dimensões de um
            // terreno e depois exibir a área do terreno.
            while (true)
            {
                double baseRet = 0, altura = 0;
                Console.WriteLine("_________________________________________________");
                Console.WriteLine("       Insira as dimensões do terreno AxB ");
                Console.WriteLine("_________________________________________________\n");
                string[] entrada = Console.ReadLine()!.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (entrada.Length == 2 &&
                    double.TryParse(entrada[0].Trim(), out baseRet) &&
                    double.TryParse(entrada[1].Trim(), out altura))
                {
                    double area = baseRet * altura;
                    Console.WriteLine("_________________________________________________");
                    Console.WriteLine($"    A área  do terreno é de: {area}cm³");
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