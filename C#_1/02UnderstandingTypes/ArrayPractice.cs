using System;

namespace _02UnderstandingTypes
{
    public class ArrayPractice
    {
        public void LongestSeq(int[] array)
        {
            int n = array.Length;
            // find the leftmost longest seq of num
            // loop over and then update the max
            int max = 0;
            int occur = 1;
            int ch = array[0];

            for (int i =1; i< n;i++)
            {
                
                if (array[i] != array[i-1])
                {
                    occur = 0;
                }
                occur += 1;
                if (occur > max){
                    max = occur;
                    ch = array[i];
                }
            }

            Console.WriteLine(string.Join(' ', Enumerable.Repeat(ch, max)));
        }
        public void MostFreq(int[] array)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();
            int n = array.Length;

            //build dictionary
            for (int i = 0; i < n; i++)
            {
                int key = array[i];
                if (freq.ContainsKey(key))
                {
                    int occur = freq[key];
                    occur++;
                    freq[key] = occur;
                }
                else
                {
                    freq.Add(key, 1);
                }
            }

            // find max frequency.
            int min_count = 0;
            int res = -1;

            foreach (KeyValuePair<int,int> pair in freq)
            {
                // keep the leftmost
                if (min_count < pair.Value)
                {
                    res = pair.Key;
                    min_count = pair.Value;
                }
            }
            Console.WriteLine(res);
        }

        public int[] SumOfRotate()
        {
            Console.WriteLine("input array(separated by space): ");
            string temp = Console.ReadLine();
            string[] array = temp.Split(" ");

            Console.WriteLine("num of rotation: ");
            int rotate = int.Parse(Console.ReadLine());

            int[] sums = new int[array.Length];
            for (int r = 1; r <= rotate; r++)
            {
                
                string x = array[(array.Length - 1)];
                for (int i = (array.Length - 1); i > 0; i--)
                {
                    array[i] = array[i - 1];
                    sums[i] += int.Parse(array[i - 1]);
                }
                array[0] = x;
                sums[0] += int.Parse(array[0]);

            }
            
            return sums;
        }
        public void CopyArray()
        {
            int[] originalArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] copiedArray = new int[originalArray.Length];

            for (int i = 0; i < originalArray.Length; i++)
            {
                copiedArray[i] = originalArray[i];
            }

            Console.WriteLine("Original Array:");
            foreach (int i in originalArray)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\nCopied Array:");
            foreach (int i in copiedArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


        }
        public void listElement()
        {
            List<string> grocery = new List<string>();
            while (grocery != null) {
                Console.WriteLine("Grocery List: " + string.Join(", ", grocery));
                Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");

                string input = Console.ReadLine();
                string item = "";
                if (input.Contains("--"))
                {
                    grocery.Clear();
                    Console.WriteLine("Clearing List");
                    break;
                }
                else if (input.Contains('+'))
                {
                    item = input.TrimStart(' ', '+');
                    grocery.Add(item);
                }
                else if (input.Contains('-')) {
                    item = input.TrimStart(' ', '-');
                    if (grocery.Contains(item))
                    {
                        grocery.Remove(item);
                    }
                    else
                    {
                        Console.WriteLine("Item is not in the list\n");
                    }

                }
            }

        }
        public int[] FindPrimesInRange(int startNum, int endNum)
        {
            List<int> prime = new List<int>();
            
            for (int i = startNum; i <= endNum; i++)
            {
                int m = i / 2;
                int flag = 0;
                for (int j = 2; j <= m; j++)
                {
                    if (i % j == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0){
                    prime.Add(i);
                }
            }

            return prime.ToArray();

        }
    }
}

