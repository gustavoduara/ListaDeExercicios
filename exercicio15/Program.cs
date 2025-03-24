namespace Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal peso, altura, imc;

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Calculadora de IMC");
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("Digite o seu peso (em kg): ");
            peso = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite a sua altura (em metros): ");
            altura = Convert.ToDecimal(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc < 18.5m)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc >= 18.5m && imc < 25)
            {
                Console.WriteLine("Peso normal");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Acima do peso");
            }
            else
            {
                Console.WriteLine("Obeso");
            }

            Console.ReadLine();
        }
    }
}