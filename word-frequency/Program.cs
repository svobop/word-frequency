using System;
using System.Collections.Generic;
using System.IO;

namespace word_frequency
{
    class Program
    {
        public static void getWordAtFrequency(int frequency)
        {
            try
            {
                using (StreamReader sr = File.OpenText("input.txt"))
                {

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("input.txt doesn't exist");
            }
            
        }

        static void Main(string[] args)
        {
            getWordAtFrequency(2);
        }
    }
}