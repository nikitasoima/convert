using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace convert
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;


            Console.WriteLine("Введите сторону a первого конверта: ");
            try
            {

                a = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Повторите попытку");
                a = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Введите сторону b первого конверта: ");
            try
            {
                b = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Повторите попытку");
                b = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Введите сторону c второго конверта: ");
            try
            {
                c = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Повторите попытку");
                c = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Введите сторону d второго конверта: ");
            try
            {
                d = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Повторите попытку");
                d = Convert.ToDouble(Console.ReadLine());
            }
            if (((a == c) && (b == d) || (a == d) && (b == c)))
                Console.WriteLine("Конверты одинаковы");
            else
            {
            if (((a == c) && (b == d) || (a == d) && (b == c))) 
                Console.WriteLine("Конверты одинаковы"); 
            else 
            { 
            if (((a < c) && (b < d) || (a < d) && (b < c))) 
            Console.WriteLine("Первый конверт можно вложить во второй"); 
            else if (((c < a) && (d < b) || (d < a) && (c < b))) 
            Console.WriteLine("Второй конверт можно вложить в первый"); 
            }
            Console.ReadLine();
        }





    }
}
