using System;
using System.Collections.Generic;
using System.IO;

namespace word_frequency
{
    class Program
    {
        public static void getWordAtFrequency(int frequency)
        {
            string textLines = "";
            try
            {
                using (StreamReader sr = File.OpenText("input.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        textLines = textLines + " " + line;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("input.txt wasn't found");
            }

            var listWords = textLines.Split(" ");
            var uniqueWords = new HashSet<string>(listWords);

            using (StreamWriter sw = new StreamWriter(File.OpenWrite("output.txt")))
            {
                foreach (var word in uniqueWords)
                {
                    int count = 0;
                    foreach (var inputWord in listWords)
                    {
                        if (inputWord == word)
                        {
                            count++;
                        }
                    }

                    if (count == frequency)
                    {
                        sw.WriteLine(word);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            getWordAtFrequency(1);
        }
    }
}