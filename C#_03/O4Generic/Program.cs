using System;

namespace O4Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            MyList<int> mylist = new MyList<int>();
            for(int i = 0; i < 10; i++)
            {
                mylist.Add(i+1);
            }
            Console.WriteLine(mylist.Count);
            mylist.Remove(3);

            Console.WriteLine("upding list");

            for (int i = 0; i < mylist.Count; i++)
            {
                Console.WriteLine(mylist.Find(i));
            }

            mylist.InsertAt(11, 3);
            
            Console.WriteLine("updating list");

            for (int i = 0; i < mylist.Count; i++)
            {
                Console.WriteLine(mylist.Find(i));
            }

        }
    }
}
