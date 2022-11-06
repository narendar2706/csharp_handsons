using System;

namespace cs_handsons
{
    class rev
    {
       static void Main(string[] args)
        {

            Console.WriteLine("Enter the string :");
            string sentence1 = Console.ReadLine();
            rev m1=new rev();
            Console.WriteLine(rev.reverse_sentence(sentence1));
                        
        }
        public static string reverse_sentence(string str)
            {
                string[] sentenceWords = str.Split(' ');
                Array.Reverse(sentenceWords);
                string newSentence = string.Join(" ", sentenceWords);
                return newSentence;
            }
    }
}
