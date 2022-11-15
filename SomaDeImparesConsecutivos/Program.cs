using System;

namespace curso
{
    class Progam
    {
        static void Main(string[] args)
        {
            int x, y, min, max, soma;
            Console.WriteLine("Digite 2 números para a soma de impares consecutivos:");


            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x < y)
            {
                min = x;
                max = y;
            }
            else
            {
                min = y;
                max = x;
            }

            soma = 0;
            for (int i=min+1; i<max; i++)
            {
                if (i % 2 != 0)
                {
                    soma = soma + i;
                }
            }
            Console.WriteLine(soma);

            Console.ReadLine();

        }
    }
}