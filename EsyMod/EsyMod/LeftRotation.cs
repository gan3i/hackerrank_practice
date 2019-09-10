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

    // Complete the rotLeft function below.
    static int[] rotLeft(int[] a, int d)
    {
        int[] temp = new int[d];

        for (int i = 0; i < d; i++)
            temp[i] = a[i];

        for (int i = d; i < a.Length; i++)
        {
            a[i - d] = a[i];
        }

        for (int i = 0; i < d; i++)
            a[a.Length - d + i] = temp[i];

        return a;

    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@"C:\Users\nageshappag\Documents\Git\hackerrank_practice\write.txt", true);

        string[] nd = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;
        int[] result = rotLeft(a, d);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
