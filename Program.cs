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
            string[] words = { "myli", "naveen", "lavi", "santhosh", "kiru" };
            Array.Sort(words);
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
            string value = "naveen";

            int res = Array.BinarySearch(words, value);
            if (res > 0)
            {
                Console.WriteLine(" index num is{0}.{1} word is  founded", res, value);
            }
            else
            {
                Console.WriteLine("word is not in list");
            }           
        }
        public void SortArray()
        {
            string[] words = { "myli", "naveen", "lavi", "santhosh", "kiru" };
            Array.Sort(words);
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
        static void Main(string[]args)
        {
            Program program = new Program();
            Console.WriteLine("1.Binary search");
            Console.WriteLine("2.Sort list");
            Console.WriteLine("Enter your choice : ");
            int ch=int.Parse(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    program.BinarySearch();
                    break;
                    case 2:
                    program.SortArray();
                    break;
                default:
                    Console.WriteLine("invalid input..");
                    break;
            }
            
        }
    }

}