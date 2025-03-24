namespace exercicio02
{
    internal class Program
    {
        //Crie um programa para calcular o volume de um Cilindro
        //V = π r² h
        static void Main(string[] args)
        {
            decimal valorPI = Convert.ToDecimal(Math.PI);

            decimal raio = 0;
            decimal altura = 0;
            decimal volume = valorPI * raio * raio * altura;

            Console.WriteLine($"O volume do cilindro é: {volume} cm²");

            Console.ReadLine();


        }
    }
}
