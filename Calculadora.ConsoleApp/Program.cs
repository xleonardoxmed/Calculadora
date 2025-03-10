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
                Console.WriteLine(" 5 - Tabuada");
                Console.WriteLine(" 6 - Sair");

                Console.Write("\n Escolha uma Opção: ");

                string opcao = Console.ReadLine().ToUpper(); // Maiúsculo

                //Estrutura de decisão (se/senao)
                if (opcao == "6")
                    break;

                else if (opcao == "5")
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Tabuada de Malandro");
                    Console.WriteLine("------------------------------");
                   
                    //digita 1 número
                    Console.Write("\nDigite o Número: ");
                    int numeroTabuada = Convert.ToInt32(Console.ReadLine());

                    //até o 10
                    for(int contador = 1; contador <= 10; contador++) //++ ou +1
                    {

                        int resultadoTabuada = numeroTabuada * contador;
                        
                        Console.WriteLine($"{numeroTabuada} x {contador} = {resultadoTabuada}");
                    }

                    Console.ReadLine();
                    continue;

                }

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
                  
                    if (segundoNumero == 0)
                    {
                        Console.WriteLine("\nImpossível dividir por '0' INSIRA UMA OPÇÃO VÁLIDA.");
                        Console.ReadLine();
                        continue;
                    }
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
