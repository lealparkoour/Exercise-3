using System;

namespace NumberP
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, x = 1, d;
            Console.Write("enter the number: ");
            num = Convert.ToInt32(Console.ReadLine());

            d = primo(num, x);

          static  int primo(int  num, int  x)
            {
                if (x == num)
                    return 1;
                else
                {
                    if (num % x == 0)
                        return 1 + primo(num, x + 1);
                    else
                        return 0+ primo(num, x + 1);

                }
            }



            if (d==2)
            
                Console.Write("es primo : ");
                else
                    Console.Write("no es primo : ");
            
        }
    }
}
