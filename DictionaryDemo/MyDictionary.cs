using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DictionaryDemo
{
    class MyDictionary<TKey, TValue>
    {
        private TKey[] keys;
        private TValue[] values;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            if (keys.Contains(key) || values.Contains(value))
            {
                Console.WriteLine("Overlapping key or value, please change the values");
            }
                
            var tempKeyArray = keys;
            var tempValueArray = values;

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < keys.Length - 1; i++)
            {
                keys[i] = tempKeyArray[i];
                values[i] = tempValueArray[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

        public void GetAll()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("Key: {0} -- Value: {1}", keys[i], values[i]);
            }
            
        }
        public void GetByKey(TKey key)
        {
            Console.WriteLine("Key: {0} -- Value: {1}",keys[Array.IndexOf(keys,key)],values[Array.IndexOf(keys, key)]);
        }
    }
}
