/*using System.Linq;

// Importa List<T>.
using System.Collections.Generic;

using System.Globalization;


class SomaMedia{
    static void Main(){
       
        Console.WriteLine("Quantos números deseja informar (3 a 10)?: ");
        int quantidade = int.Parse(Console.ReadLine());
 
        // Usando um while para fazer essa validação, para que peça até que seja usado um valor válido, um if verificaria apenas uma vez
        while (quantidade < 3 || quantidade > 10){
            Console.WriteLine("Valor inválido! Digite entre 3 e 10: ");
            quantidade = int.Parse(Console.ReadLine());
        }
        // CLASSE LIST é uma coleção dinâmica, fortemente tipada e redimensionável, usada 
        // para armazenar, ordenar e manipular grupos de objetos de um tipo específico
        List<double> numeros = new List<double>();


        // Loop 'for' — usado quando se sabe quantas vezes o bloco será executado.
        // Estrutura: (inicialização; condição; incremento)
 
        for (int i = 0; i < quantidade; i++){
            Console.Write($"Digite o número {i + 1}: ");
            {
                double numero;
                while(!double.TryParse(Console.ReadLine(), out numero))
                {
                    Console.Write("Valor inválido, digite novamente: ");
                }
               
                numeros.Add(numero);
            }
        }
 
        double soma = numeros.Sum();
        double media = numeros.Average();
 
        Console.WriteLine($"Soma: {soma}");
        Console.WriteLine($"Média: {media}");
 
    }
    
        static double CalcularSoma(List<double> lista)
    {
    // Loop 'foreach' — usado para percorrer cada elemento de uma coleção.
    // Mais simples que o 'for', mas sem acesso ao índice diretamente.
        double soma = 0;
        foreach (double num in lista){
 
            soma += num;
        }
        return soma;
    }
 
    static double CalcularMedia (List<double> lista){
        double soma = CalcularSoma(lista);
        return soma / lista.Count;
    }
}
 */