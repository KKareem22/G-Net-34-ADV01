using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_ADV01.Classes
{
    internal class SafeList<T>
    {
        private T[] _item;

        public SafeList(T[] item)
        {
            _item = item;
        }
        public T? GetItem(int index)
        {
            if(index>=0 && index<_item.Length)
                return _item[index];
            return default(T);
        }
    }
}
