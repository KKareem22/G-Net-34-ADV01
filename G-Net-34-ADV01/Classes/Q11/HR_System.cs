using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_ADV01.Classes.Q11
{
    internal class HR_System
    {
        public void ProcessEmployee<T>(T emp) where T : Employee
        {
            emp.Work();
        }
    }
}
