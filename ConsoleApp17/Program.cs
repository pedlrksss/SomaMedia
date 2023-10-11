using System;

namespace Project
{
    class SomaMedia
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("PROGRAMA PARA CALCULAR A MEDIA ENTRE 2 OU MAIS NUMEROS");
            Console.WriteLine("------------------------------------------------------");
            
            Console.WriteLine();
            Console.WriteLine("Quantos numeos deseja informar? ");
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o valor: ");
               int v = int.Parse(Console.ReadLine());
                list.Add(v);  
            }
            foreach (var item in list)
            { 
                sum += item;
            }
            if (n > 0) 
            {
                int result = sum / n; 
                Console.WriteLine("Soma: " + sum);
                Console.WriteLine("Média: " + result);
            }
            else
            {
                Console.WriteLine("Não é possível calcular a média.");
            }


        }
    }
}
