namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal salario, salarioComAumento, salarioFinal, imposto;

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Calculadora de salário");
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("Digite o salário do funcionário: ");
            salario = Convert.ToInt32(Console.ReadLine());

            salarioComAumento = salario * 1.15m;
            imposto = salarioComAumento * 0.08m;
            salarioFinal = salarioComAumento - imposto;

            Console.WriteLine($"Salário inicial: R$ {salario}");
            Console.WriteLine($"Salário com aumento: R$ {salarioComAumento}");
            Console.WriteLine($"Salário final: R$ {salarioFinal}");
        }
    }
}