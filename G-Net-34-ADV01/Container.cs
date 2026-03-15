using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_ADV01
{
    internal class Container<T>
    {
        private readonly List<T> _list = [];
        public void Add(T item)=>_list.Add(item);
        public List<T> GetAll()=>_list;
    }
}
