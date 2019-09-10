using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the repeatedString function below.
    static long repeatedString(string s, long n)
    {
        long aCount1 = 0;
        long aCount2 = 0;
        long l = s.Length;
        string s1 = s.Substring(0, Convert.ToInt32(n % l));
        foreach (char c in s)
        {
            if (c == 'a')
            {
                aCount1++;
            }
        }

        foreach (char c in s1)
        {
            if (c == 'a')
            {
                aCount2++;
            }
        }

        return ((aCount1 * (n / l)) + aCount2);

    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@"C:\Users\nageshappag\Documents\Git\hackerrank_practice\write.txt", true);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine());

        long result = repeatedString(s, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
