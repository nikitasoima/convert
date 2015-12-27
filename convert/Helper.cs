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
                x = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Повторите попытку");
                Input(s, out x);
            }
        }
    }
}
