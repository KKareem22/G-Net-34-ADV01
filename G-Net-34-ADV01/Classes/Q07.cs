using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_ADV01.Classes
{
    internal class Q07<T> where T :struct
    {
        public void DisplaySum<T>(T val1, T val2) 
        {        
            Console.WriteLine($"The inputs are: {val1} and {val2}");
        }

    }
}
