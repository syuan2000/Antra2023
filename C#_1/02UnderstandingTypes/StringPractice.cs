using System;
using System.Collections;
using System.Collections.Generic;

namespace _02UnderstandingTypes
{
	public class StringPractice
	{
		public void ReverseString(string str)
		{
            //Convert the string to char array, reverse it, then convert it to string again
            Console.WriteLine("Convert to char array:");
            char[] temp = str.ToCharArray();
			Array.Reverse(temp);
			Console.WriteLine(new string(temp));



            //Print the letters of the string in back direction(from the last to the first) in a for-loop
            Console.WriteLine("Reverse Print:");
            for (int i = str.Length-1; i >= 0; i--)
			{
				Console.Write(str[i]);
			}


        }
		public void ReverseWithPunc(string str)
		{
            Console.WriteLine("\nOriginal string: "+str);
            string[] separators = { ".", ",", ":", ";", "=", "(", ")", "&", "[", "]", "\"", "'", "\\", "/", "!", "?", " " };
            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);

            int i = 0;
            bool flag = true;

            Console.Write("Reversed string: ");
            foreach (char c in str)
            {
                if (separators.Contains(c.ToString()))
                {
                    Console.Write(c);
                    flag = true;
                }
                else if(flag)
                {
                    Console.Write(words[i]);
                    flag = false;
                    i++;
                }
                else
                {
                    continue;
                }
            }

        }
        static bool IsPalindrome(string str)
        {
            // left and right pointer
            int l = 0;
            int r = str.Length - 1;

            while (r > l)
            {
                if (str[l++] != str[r--])
                {
                    return false;
                }
            }
            return true;
        }

        public void PalindromeList(string str) {
            
            string[] separators = { ".", ",", ":", ";", "=", "(", ")", "&", "[", "]", "\"", "'", "\\", "/", "!", "?", " " };
            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            ArrayList result = new ArrayList();


            foreach (string word in words)
            {
                if (IsPalindrome(word))
                {
                    result.Add(word);
                }
            }
            foreach (string r in result)
                Console.Write( r + ", ");
        }
        public void ParseURL(string protocol, string server, string resource)
        {
            Console.WriteLine("URL result: ");
            if (server=="") {
                Console.WriteLine("server is mandatory!");
                return;
            }
            string url = "";
            if (protocol != "")
            {
                url += protocol;
                url += "://";
                
            }
            url += server;
            if (resource != "")
            {
                url += "/" + resource;
            }
            Console.WriteLine(url);


        }

    }
}

