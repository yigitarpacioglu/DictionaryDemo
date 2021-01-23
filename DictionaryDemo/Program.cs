using System;
using System.Collections.Generic;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
            dictionary.Add(1,"Yiğit");
            dictionary.Add(2,"Cihat");
            dictionary.Add(3,"Berkay");

            dictionary.GetAll();
            dictionary.GetByKey(2);
        }
    }
}
