using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_ADV01.Classes.Q11
{
    internal class Engineer:Employee
    {
        public override void Work()
        {
            Console.WriteLine($"{Name} : is coding....");
        }
    }
}
