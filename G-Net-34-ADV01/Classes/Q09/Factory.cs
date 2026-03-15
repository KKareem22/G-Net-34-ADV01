using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_ADV01.Classes.Q09
{
    internal class Factory<T> where T :new()
    {
        public T Create() => new T();
        public List<T> CreateMany(int count)
        {
            var List = new List<T>();
            for (int i = 0; i < count; i++)
            {
                List.Add(new T());
            }
            return List;

        }
    }
}
