using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_ADV01.Classes
{
    internal interface IRepositry<T>
    {
        void Add(T item);
        List<T> GetAll();
        void Delete(int Id);
        T? GetById(int Id);
    }
}
