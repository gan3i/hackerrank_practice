using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Solution
{
    class Solution
    {
        static void Main(string[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT */
            string s = Console.ReadLine().Trim();

            string s1=manipulate(s);

            Console.WriteLine(s1);
        }
        private static string manipulate(string s)
        {
            StringBuilder sB = new StringBuilder();
            int i = 1;
            foreach (char c in s)
            {
                if((i%3==0) && (i % 5 == 0))
                {
                    sB.Append(" ");
                }
                else if (i % 3 == 0)
                {
                    sB.Append(c.ToString().ToUpper());
                }
                else if (i % 5 == 0)
                {
                    sB.Append(" ");
                }
                else
                {
                    sB.Append(c.ToString());
                }
                i++;
            }

            return sB.ToString();
        }
    }
}
