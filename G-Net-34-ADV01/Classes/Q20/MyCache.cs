using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_ADV01.Classes.Q20
{
    internal class MyCache<TKey,TValue>
    {
        private TKey[] _keys;
        private CacheItem<TValue>[] _items;
        private int _counter;
        public MyCache(int capacity)
        {
            _keys = new TKey[capacity];
            _items=new CacheItem<TValue>[capacity];
            _counter = 0;
            
        }
        public void Add(TKey key,TValue value,int seconds)
        {
            for(int i=0;i<_counter;i++)
            {
                if (_keys[i].Equals(key))
                {
                    _items[i].Value = value;
                    _items[i].ExpirtyTime=DateTime.Now.AddSeconds(seconds);
                    return;
                }
            }
            if(_counter<_keys.Length)
            {
                _keys[_counter] = key;
                _items[_counter] = new CacheItem<TValue>
                {
                    Value = value,
                    ExpirtyTime = DateTime.Now.AddSeconds(seconds)
                };
                _counter++;
            }
        }
        public TValue? Get(TKey key)
        {
            for(int i=0;i<_counter;i++)
            {
                if (_keys[i].Equals(key))
                {
                    if (DateTime.Now <= _items[i].ExpirtyTime)
                    {
                        return _items[i].Value;
                    }
                    Remove(key);
                    return default(TValue);
                }
            }
            return default(TValue);
        }
        public void Remove(TKey key)
        {
            for(int i=0;i<_counter;i++)
            {
                if(_keys.Equals(key))
                {
                    for(int j=i;j<_counter-1;j++)
                    {
                        _keys[j]=_keys[j+1];
                        _items[j]=_items[j+1];
                    }
                    _counter--;
                    return;
                }
            }
        }
    }
}
