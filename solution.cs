using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string entrada = Console.ReadLine();
        
        int[] numero =  Array.ConvertAll(entrada.Split(' '), int.Parse);
        int soma = 0;
        bool alternar = true;

        int maior = Math.Max(numero[0], numero[1]);
        int menor = Math.Min(numero[0], numero[1]);


        for(int i = menor; i <= maior; i++)
        {
          if(alternar)
          {
            soma += i;
          }else
          {
            soma -= i;
          }
            alternar = !alternar;
        }

        Console.WriteLine(soma);
    }
}