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
            //var index = GetHash(key);

            //var entry = _hashTable[index];

            //var newItem = new KeyValuePair {Key = key, Value = value};

            //if (entry == null)
            //{
            //    entry = _hashTable[index] = new LinkedList<KeyValuePair>();
            //}
            //else
            //{
            //    entry = _hashTable[index];
            //}

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

            return entry == null ? "null" : entry.Value;
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
                throw new ArgumentNullException();
            }

            if (IsCollision(entry))
            {
                foreach (var keyValuePair in entry)
                {
                    if (keyValuePair.Key == key)
                    {
                        return keyValuePair;
                    }

                }
            }

            return entry.Last.Value;
        }

        private LinkedList<KeyValuePair> GetEntry(int key)
        {
            return _hashTable[GetHash(key)];
        }

        private LinkedList<KeyValuePair> GetEntryOrCreate(int key)
        {
            var index = GetHash(key);
            var entry = _hashTable[index] ?? new LinkedList<KeyValuePair>();

            return entry;
        }

        private int GetHash(int key)
        {
            return key % _hashTable.Length;
        }

        private static bool IsCollision(LinkedList<KeyValuePair> keyValuePairs)
        {
            return keyValuePairs?.Last != null;
        }
    }
}