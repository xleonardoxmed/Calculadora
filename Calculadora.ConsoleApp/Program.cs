namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Calculadora de Malandro");
            Console.WriteLine("------------------------------");

            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Sair");
           
            Console.Write("Escolha uma Opção: ");

            string opcao = Console.ReadLine().ToUpper(); // Maiúsculo
           

            //Estrutura de decisão (se/senao)
            if (opcao == "S")
            {
                return;
            }

            Console.Write("Digite o Primeiro Número: ");
            string primeiroNumeroString = Console.ReadLine();
            int primeiroNumero = Convert.ToInt32(primeiroNumeroString);

            Console.Write("Digite o Primeiro Número: ");
            string segundoNumeroString = Console.ReadLine();
            int segundoNumero = Convert.ToInt32(segundoNumeroString);

            int resultado = 0;

            if (opcao == "1")
            {
                 resultado = primeiroNumero + segundoNumero;
            }

            else 
            {
                 resultado = primeiroNumero - segundoNumero;
            }
            
            Console.WriteLine("\n" + resultado);

            Console.ReadLine(); // leia

        }
    }
}
