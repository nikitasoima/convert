using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converts
{
    class Helper
    {
        static public void Input(string s, out double x)
        {
            Console.WriteLine("Введите сторону {0} конверта: ", s);
        try
        {
        string A; 
        A = Console.ReadLine(); 
        if (A == "exit") 
        { 
        Environment.Exit(0); 
        }
        x = Convert.ToDouble(A);
        }
        catch
        {
        Console.WriteLine("Повторите попытку");
        Input(s, out x); 
        }

        }
        
    }
   
}


