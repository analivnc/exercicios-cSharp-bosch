/*using System;

class Program
{
    static void Main()
    {
        string opcao;

        
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");

            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    RealizarOperacao('+');
                    break;
                case "2":
                    RealizarOperacao('-');
                    break;
                case "3":
                    RealizarOperacao('*');
                    break;
                case "4":
                    RealizarOperacao('/');
                    break;
                case "0":
                default:
                Console.WriteLine("Opção inválida! Tente novamente.");
                break;

                   
            }

        } 
    }

    static void RealizarOperacao(int operacao)
    {
        Console.Write("Digite o primeiro número: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        int resultado = 0;

        switch (operacao)
        {
            case '+':
                resultado = numero1 + numero2;
                break;
            case '-':
                resultado = numero1 - numero2;
                break;
            case '*':
                resultado = numero1 * numero2;
                break;
            case '/':
                resultado = numero1 / numero2;
                break;
            
            default:
            Console.WriteLine("Opção inválida! Tente novamente.");
            break;

            
        }

        Console.WriteLine("Resultado:" + resultado);
    }
}

*/
