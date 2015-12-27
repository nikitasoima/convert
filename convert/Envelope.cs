using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converts
{
     class Envelope
    {      
         double size1;
         double size2;
         public double X
         {
             get {return size1;}
         }
         public double Y
         {
             get { return size2;}
         }
         public Envelope()
         {

         }
         public Envelope( double newsize1, double newsize2)
         {
             size1 = newsize1;
             size2 = newsize2;
         }       
         static public void Input(string s, out double x)
         {
             Console.WriteLine("Введите сторону {0} конверта: ", s);
             try
             {
                 x = Convert.ToDouble(Console.ReadLine());
             }
             catch
             {
                 Console.WriteLine("Повторите попытку");
                 Input(s, out x);
             }
         }
         public void Compare(Envelope convert)
         {
             double a = this.X;
             double b = this.Y;
             double c = convert.X;
             double d = convert.Y;
             if (((a == c) && (b == d) || (a == d) && (b == c)))
            { 
                 Console.WriteLine("Конверты одинаковы");         
            }   
            else
                {
                    if (((a < c) && (b < d) || (a < d) && (b < c)))
                        Console.WriteLine("Первый конверт можно вложить во второй");
                    else if (((c < a) && (d < b) || (d < a) && (c < b)))
                        Console.WriteLine("Второй конверт можно вложить в первый");
                }
         }   
    }
}
