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
            Envelope.input("а первого", out a);
            Envelope.input("b первого", out b);
            Envelope.input("c второго", out c);
            Envelope.input("d второго", out d);
            Envelope convert1 = new Envelope(a, b);
            Envelope convert2 = new Envelope(c, d);          
            convert1.Compare(convert2);
            Console.WriteLine("Введите слово exit для выхода");
            while (Console.ReadLine() != "exit")
            {
                Console.WriteLine("Введите слово exit для выхода");
            }
            return;
        }
    }
}
