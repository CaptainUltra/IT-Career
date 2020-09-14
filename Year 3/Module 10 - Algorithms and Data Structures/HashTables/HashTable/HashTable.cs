using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HashTable
{
    class HashTable<TKey, TValue> : IEnumerable<KeyValue<TKey, TValue>>
    {
        private LinkedList<KeyValue<TKey, TValue>>[] slots;
        public const int InitialCapacity = 16;
        public const float LoadFactor = 0.75f;
        public int Count { get; private set; }
        public int Capacity { get; private set; }
        
        public HashTable()
        {
            this.Capacity = InitialCapacity;
            this.slots = new LinkedList<KeyValue<TKey, TValue>>[InitialCapacity];
            this.Count = 0;
        }
        public HashTable(int capacity)
        {
            this.Capacity = capacity;
            this.slots = new LinkedList<KeyValue<TKey, TValue>>[capacity];
            this.Count = 0;
        }
        public void Add(TKey key, TValue value)
        {
            GrowIfNeeded();
            int slotNumber = this.FindSlotNumber(key);
            if(this.slots[slotNumber] == null)
            {
                this.slots[slotNumber] = new LinkedList<KeyValue<TKey, TValue>>();
            }
            foreach (var element in this.slots[slotNumber])
            {
                if(element.Key.Equals(key))
                {
                    throw new ArgumentException("Key already exists: " + key);
                }
            }
            var newElement = new KeyValue<TKey, TValue>(key,value);
            this.slots[slotNumber].AddLast(newElement);
            this.Count++;
        }

        private int FindSlotNumber(TKey key)
        {
            var slotNumber = Math.Abs(key.GetHashCode()) % this.slots.Length;
            return slotNumber;
        }

        private void GrowIfNeeded()
        {
            if((float)(this.Count +1 ) / InitialCapacity > LoadFactor)
            {
                this.Grow();
            }
        }
        private void Grow()
        {
            this.Capacity *= 2;
            var slotsNew = new LinkedList<KeyValue<TKey, TValue>>[Capacity];
            Array.Copy(slots, 0, slotsNew, 0, slots.Length);
            slots = slotsNew;
        }

        public bool AddOrRepalce(TKey key, TValue value)
        {
            throw new NotImplementedException();
        }
        public TValue Get(TKey key)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValue<TKey, TValue>> GetEnumerator()
        {
            foreach (var elements in this.slots)
            {
                if(elements != null)
                {
                    foreach (var element in elements)
                    {
                        yield return element;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public TValue this[TKey key]
        {
            get => throw new NotImplementedException();
        }
        public bool TryGetValue(TKey key, out TValue value)
        {
            throw new NotImplementedException();
        }
        public KeyValue<TKey, TValue> Find(TKey key)
        {
            int slotNumber = this.FindSlotNumber(key);
            LinkedList<KeyValue<TKey, TValue>> slot = slots[slotNumber];
            if (slot == null) return null;

            KeyValue<TKey, TValue> keyValue = slot.Where(x => x.Key.Equals(key))
                .FirstOrDefault();

            return keyValue;
        }
        public bool ContainsKey(TKey key)
        {
            throw new NotImplementedException();
        }
        public bool Remove(TKey key)
        {
            throw new NotImplementedException();
        }
        public void Clear()
        {
            throw new NotImplementedException();
        }        
    }
}