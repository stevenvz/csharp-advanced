﻿using System;

namespace L5_Generics
{
    public class GenericsDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {
            
        }
    }
    public class GenericList<T>
    {
        public void Add(T value)
        {
            
        }

        public T this[int index]
        {
            get { throw new NotImplementedException();}
        }
    }
}