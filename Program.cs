using System;

   namespace Aula_de_PC1_SeqPares
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Digite qualquer número inteiro real diferente de zero:  ");
            Console.WriteLine("-----------------------------------------------------");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            valor = int.Parse(Console.ReadLine());
            Console.ResetColor();
            if(valor % 2 == 0)
            {
               Console.WriteLine($"Entre 0 e {valor} há:\n");
               for ( int i = 0; i <= valor; i  = i + 2)
               {
                  Console.Write($"{i} ");
                }
            }
           else
           {
               Console.WriteLine("Você digitou um número ímpar!\n");
               Console.WriteLine($"Entre 0 e {valor} há:\n ");
               for ( int i = 0; i <= valor; i = i + 2)
               {
                   Console.Write($"{i} "); 
               }
            }
        } 
    }
}
