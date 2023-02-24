using System;
namespace O4Generic
{
    // so this generic can take any types of list
    public class MyStack<T>
    {
        private List<T> items;

        public MyStack()
        {
            items = new List<T>();
        }

        public int Count
        {
            get { return items.Count; }
        }

        public T Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            T item = items[Count - 1];
            items.RemoveAt(Count - 1);
            return item;
        }

        public void Push(T item)
        {
            items.Add(item);
        }
    }


}

