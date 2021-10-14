using System;

namespace calculadora_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            double n1;
            double n2;
            double resultado;
            bool validacao = true;
            Program program = new Program();

            Console.WriteLine("###Sejam bem vindos a calculadora DOTNET!###");
            do
            {
                Console.WriteLine("\nEscolha a operação desejada: ");
                Console.WriteLine("(1) Soma\n(2) Subtração\n(3) Multiplicação\n(4) Divisão\n(5) Sair");

                Console.WriteLine("Digite sua opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o primeiro número: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número: ");
                        n2 = Convert.ToDouble(Console.ReadLine());

                        resultado = program.Soma(n1, n2);
                        Console.WriteLine("O resultado da sua soma é {0}!", resultado);
                        break;
                    case 2:
                        Console.WriteLine("Digite o primeiro número: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número: ");
                        n2 = Convert.ToDouble(Console.ReadLine());

                        resultado = program.Subtracao(n1, n2);
                        Console.WriteLine("O resultado da sua subtração é {0}!", resultado);
                        break;
                    case 3:
                        Console.WriteLine("Digite o primeiro número: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número: ");
                        n2 = Convert.ToDouble(Console.ReadLine());

                        resultado = program.Multiplicacao(n1, n2);
                        Console.WriteLine("O resultado da sua multiplicação é {0}!", resultado);
                        break;
                    case 4:
                        Console.WriteLine("Digite o primeiro número: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número: ");
                        n2 = Convert.ToDouble(Console.ReadLine());

                        resultado = program.Divisao(n1, n2);
                        Console.WriteLine("O resultado da sua divisão é {0}!", resultado);
                        break;
                    case 5:
                        validacao = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida, digite uma opção válida!");
                        break;
                }
                Console.WriteLine("\nAperte 'Enter' para retornar ao Menu");
                Console.ReadLine();
                Console.Clear();
            } while (validacao);

                        
        }

        public double Soma(double n1, double n2)
        {
            return n1 + n2;
        }
        public double Subtracao(double n1, double n2)
        {
            return n1 - n2;
        }

        public double Multiplicacao(double n1, double n2)
        {
            return n1 * n2;
        }

        public double Divisao(double n1, double n2)
        {
            return n1 / n2;
        }
    }
}
