using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_ADV01.Classes.Q12
{
    internal class Container2
    {
        public T CreateEmpty<T>() where T:class,new() //Two Constraints 
        {
            return new T();
        }
    }
}
