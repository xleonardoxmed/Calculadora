namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //loop 0 - 1
            while (true)
            {
                Console.Clear();
                Console.WriteLine("------------------------------");
                Console.WriteLine("Calculadora de Malandro");
                Console.WriteLine("------------------------------");

                Console.WriteLine(" 1 - Somar");
                Console.WriteLine(" 2 - Subtrair");
                Console.WriteLine(" 3 - Multiplicar");
                Console.WriteLine(" 4 - Dividir");
                Console.WriteLine(" 5 - Sair");

                Console.Write("\n Escolha uma Opção: ");

                string opcao = Console.ReadLine().ToUpper(); // Maiúsculo

                //Estrutura de decisão (se/senao)
                if (opcao == "5")
                    break;



                Console.Write(" Digite o Primeiro Número: ");
                string primeiroNumeroString = Console.ReadLine();
                decimal primeiroNumero = Convert.ToDecimal(primeiroNumeroString); 

                Console.Write(" Digite o Primeiro Número: ");
                string segundoNumeroString = Console.ReadLine();
                decimal segundoNumero = Convert.ToDecimal(segundoNumeroString);

                decimal resultado = 0;

                if (opcao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;
                }

                if (opcao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                }

                if (opcao == "3")
                {
                    resultado = primeiroNumero * segundoNumero;
                }

                else if (opcao == "4")
                {
                    resultado = primeiroNumero / segundoNumero;
                }

                Console.WriteLine("------------------------------");
                Console.WriteLine("\nResultado: " + resultado.ToString("F2")); // FloatingPoints = 2
                Console.WriteLine("------------------------------");
                Console.WriteLine("\nDeseja Continuar? (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                {
                    break;
                }
            }
        }
    }
}
