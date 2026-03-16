using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_ADV01.Classes.Q20
{
    internal class CacheItem<T>
    {
        public T Value { get; set; }
        public DateTime ExpirtyTime { get; set; }
    }
}
