using System;
using System.Collections.Generic;

namespace DataStructures.Hash_Tables
{
    public class HashTable
    {
        private LinkedList<KeyValuePair>[] _hashTable;

        public HashTable(int capacity)
        {
            _hashTable = new LinkedList<KeyValuePair>[capacity];
        }

        public void Put(int key, string value)
        {
            var keyValuePair = GetKeyValuePairByKey(key);
            if (keyValuePair != null)
            {
                keyValuePair.Value = value;
                return;
            }

            GetEntryOrCreate(key).AddLast(new KeyValuePair {Key = key, Value = value});
        }

        public string Get(int key)
        {
            var entry = GetKeyValuePairByKey(key);

            if (entry == null)
            {
                throw new ArgumentNullException();
            }

            return entry.Value;
        }

        public void Remove(int key)
        {
            var keyValuePair = GetKeyValuePairByKey(key);
            if (keyValuePair != null)
            {
                GetEntry(key).Remove(keyValuePair);
            }
        }

        private KeyValuePair GetKeyValuePairByKey(int key)
        {
            var entry = GetEntry(key);

            if (entry == null)
            {
                return null;
            }

            foreach (var keyValuePair in entry)
            {
                if (keyValuePair.Key == key)
                {
                    return keyValuePair;
                }

            }

            return null;
        }

        private LinkedList<KeyValuePair> GetEntry(int key)
        {
            return _hashTable[GetHash(key)];
        }

        private LinkedList<KeyValuePair> GetEntryOrCreate(int key)
        {
            var index = GetHash(key);

            return _hashTable[index] ?? (_hashTable[index] = new LinkedList<KeyValuePair>());
        }

        private int GetHash(int key)
        {
            return key % _hashTable.Length;
        }
    }
}