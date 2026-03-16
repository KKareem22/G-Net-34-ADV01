using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_ADV01.Classes
{
    internal class Cache <T> where T : class
    {
        private T? _cache;
        public T? GetCache() => _cache;
        public void SetCache(T? cache) { _cache = cache; }
        public void Clear()=>_cache = null;
        public bool ISNull()
        {
            if (_cache == null)
                return true;
            return false;
        }
    }
}
