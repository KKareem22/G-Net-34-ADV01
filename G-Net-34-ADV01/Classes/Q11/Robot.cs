using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_ADV01.Classes.Q11
{

    internal class Robot//كلاس تاني خالص (مش وارث من ) Employee
    {
        public string Name { get; set; }
        public void Work() => Console.WriteLine($"{Name} :Robot");
    }
}
