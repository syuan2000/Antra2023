using System;
namespace O4Generic
{
	public class MyList<T>
	{
        private List<T> lists;
		public int Count { get; set; }

        public MyList()
		{
            lists = new List<T>();
			Count = 0;
        }
		public void Add(T list)
		{
			lists.Add(list);
            Count++;

		}
		public T Remove(int index)
		{
            T list = lists[index];
            lists.RemoveAt(index);
            Count--;
            return list;

        }
		public bool Contains(T element)
		{
			return lists.Contains(element);

		}
		public void Clear()
		{
            Count = 0;
			lists.Clear();
		}
		public void InsertAt(T element, int index)
		{
			// add the space for later to switch values
			lists.Add(element);

            for (int i = Count; i > index; i--)
			{
				lists[i] = lists[i - 1];
			}
			lists[index] = element;
            Count++;

		}
		public void DeleteAt(int index)
		{
			lists.RemoveAt(index);
            Count--;

		}
		public T Find(int index)
		{
			return lists[index];
		}

    }
}

