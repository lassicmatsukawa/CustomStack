using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomStack
{
    public class StackExample<T>
    {
        protected List<T> items;
        protected int MAX_SIZE = 3;
        public StackExample()
        {
            this.items = new List<T>();
        }

        public T Pop()
        {
            int itemCount = this.items.Count();
            if (itemCount > 0)
            {
                T lastItem = this.items[itemCount - 1];
                this.items.RemoveAt(itemCount - 1);
                return lastItem;
            }
            // watch msdn : https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/default
            // or just return null
            return default(T);
        }

        public void Push(T item)
        {
            this.items.Add(item);
            if (this.items.Count() > MAX_SIZE)
            {
                this.items.RemoveAt(0);
            }
            this.WatchAllitems();
        }

        public void Remove(int index)
        {
            if (this.items.ElementAtOrDefault(index) != null)
            {
                this.items.RemoveAt(index);
            }
            this.WatchAllitems();
        }

        private void WatchAllitems()
        {
            Console.WriteLine("<------------------->");
            this.items.ForEach(e => Console.WriteLine("{0}", (e as SampleData).Name));
            Console.WriteLine("<------------------->");
        }
    }
}
