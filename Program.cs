using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace AlgorithmProgram
{
    class Program
    {
        public void BinarySearch()
        {
            string[] words = { "mythili", "naveen", "lavanya", "santhosh", "kiruba" };
            Array.Sort(words);
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
           int res= Array.BinarySearch(words,"naveen");
            if(res>0)
            {
                Console.WriteLine(" index num is{0}.word is  founded",res);
            }
            else
            {
                Console.WriteLine("word is not in list");
            }
            
        }
        static void Main(string[]args)
        {
            Program program = new Program();
            program.BinarySearch();
        }
    }

}