using System;
using System.Collections.Generic;

namespace Generics
{
    // Generic classes encapsulate operations that are not specific to a particular data type.
    public class InventorySlot<T>
    {
        private List<T> items = new List<T>();

        public int Count
        {
            get { return this.items.Count; }
        }

        // Generic method with type parameter
        public void AddItem(T item)
        {
            this.items.Add(item);
        }

        public T GetItem(int index)
        {
            return this.items[index];
        }
    }
}
