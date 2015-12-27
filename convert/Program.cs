using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace convert
{
    class Program
    {
        static void input(string s , out double x)
        {
            Console.WriteLine("Введите сторону {0} конверта: ", s);
            try
            {
                x = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Повторите попытку");
                input(s, out x);
            }

        }
        static void Main(string[] args)
        {
            double a, b, c, d;
            input("а первого", out a);
            input("b первого", out b);
            input("c второго", out c);
            input("d второго", out d);          
            if (((a == c) && (b == d) || (a == d) && (b == c)))
                Console.WriteLine("Конверты одинаковы");
            else
            {
                    if (((a < c) && (b < d) || (a < d) && (b < c)))
                        Console.WriteLine("Первый конверт можно вложить во второй");
                    else if (((c < a) && (d < b) || (d < a) && (c < b)))
                        Console.WriteLine("Второй конверт можно вложить в первый");            
            }
    
            Console.WriteLine("Введите слово exit для выхода");
            while (Console.ReadLine() != "exit")
            {
                Console.WriteLine("Введите слово exit для выхода");
            }
            return;
        }
    }
}
