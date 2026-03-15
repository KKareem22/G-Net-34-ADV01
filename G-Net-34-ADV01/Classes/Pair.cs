using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_ADV01.Classes
{
    internal class Pair<TKey,Tvalue>
    {
        public Pair(TKey key, Tvalue value)
        {
            Key = key;
            Value = value;
        }

        public TKey Key { get; set; }
        public Tvalue Value { get; set; }
        public override string ToString() => $"Key :{Key} ,Value :{Value}";
        
    }
}
