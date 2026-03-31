/*using System;

class Program
{
    static void Main()
    {
        string opcao = "";

        while (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5")
        {
            Console.WriteLine("Escolha o formato da data: ");
            Console.WriteLine("1 - Padrão do Sistema");
            Console.WriteLine("2 - Formato Simples");
            Console.WriteLine("3 - Formato Longo");
            Console.WriteLine("4 - Formato Personalizado");
            Console.WriteLine("5 - RFC1123");
            Console.Write("Escolha uma opção: ");

            opcao = Console.ReadLine();

            if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5")
            {
                Console.WriteLine("Opção inválida! Tente novamente.\n");
            }
        }

        string evento = "";

        while (evento != "1" && evento != "2" && evento != "3")
        {
            Console.WriteLine("\nEscolha um evento:");
            Console.WriteLine("1 - ENIAC");
            Console.WriteLine("2 - RFC1");
            Console.WriteLine("3 - Alan Turing");
            Console.Write("Escolha uma opção: ");

            evento = Console.ReadLine();

            if (evento != "1" && evento != "2" && evento != "3")
            {
                Console.WriteLine("Opção inválida! Tente novamente.\n");
            }
        }

        DateTime data = new DateTime();
        string descricao = "";

        if (evento == "1")
        {
            data = new DateTime(1946, 8, 15);
            descricao = "No dia 15 de agosto de 1946 os norte-americanos John Eckert e John Mauchly apresentaram o ENIAC, " +
                        "o primeiro computador eletrônico do mundo.";
        }
        else if (evento == "2")
        {
            data = new DateTime(1969, 4, 17);
            descricao = "Em 17 de abril de 1969 foi feita a publicação da RFC1, " +
                        "por esse motivo considera-se esse o dia da internet até hoje.";
        }
        else if (evento == "3")
        {
            data = new DateTime(1912, 6, 23);
            descricao = "Nascimento de Alan Turing, matemático e criptoanalista britânico que é considerado o pai da informática, " +
                        "por ter sido essencial na criação de máquinas que, mais tarde, dariam origem aos PCs que utilizamos hoje.";
        }

        Console.WriteLine("\n===== RESULTADO =====");

        if (opcao == "1")
        {
            Console.WriteLine(data.ToString());
        }
        else if (opcao == "2")
        {
            Console.WriteLine(data.ToString("dd-MM-yy"));
        }
        else if (opcao == "3")
        {
            Console.WriteLine(data.ToString("dddd, d 'de' MMMM 'de' yyyy"));
        }
        else if (opcao == "4")
        {
            Console.WriteLine(data.ToString("dd-MM-yyyy HH:mm:ss"));
        }
        else if (opcao == "5")
        {
            Console.WriteLine(data.ToString("R"));
        }

        Console.WriteLine("\n===== EVENTO =====");
        Console.WriteLine(descricao);
    }
}

*/
