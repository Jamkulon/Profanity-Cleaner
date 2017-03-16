using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoshDarnYuck
{
    public class Cleaner
    {
        public Dictionary<string, string> words { get; set; }

        public string Clean(string sentence)
        {
            string[] strArr = sentence.Split(' ');

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < strArr.Length; i++)
            {
                if (words.ContainsKey(strArr[i].ToLower()))
                {
                    strArr[i] = words[strArr[i].ToLower()];
                }
                sb.Append(strArr[i] + " ");
            }
            return sb.ToString();
        }


        public Cleaner()
        {
            words.Add("darn", "d**n");
            words.Add("gosh", "g**h");
            words.Add("yuck", "y**k");

        }


    }

    public class Program
    {
        public static void Main(string[] args)
        {


        }
    }
}
