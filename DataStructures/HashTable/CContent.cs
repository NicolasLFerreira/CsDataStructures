﻿using System;

namespace CSDataStructures.DataStructures.HashTable
{
    struct CContent<T>
    {
        public CContent(string key, T data)
        {
            Key = key;
            Data = data;
        }

        public bool CheckKey(string key) => key == Key;

        public string Key { get; set; }
        public T Data { get; set; }
    }
}
