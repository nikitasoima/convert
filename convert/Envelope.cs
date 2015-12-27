using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converts
{
     class Envelope
    {      
         public double X { get; set;}
         public double Y { get; set;}      
         public Envelope()
         {

         }
         public Envelope( double newX, double newY)
         {
             X = newX;
             Y = newY;
         }              
         public void Compare(Envelope secondEnv)
         {
             double a = X;
             double b = Y;
             double c = secondEnv.X;
             double d = secondEnv.Y;
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
