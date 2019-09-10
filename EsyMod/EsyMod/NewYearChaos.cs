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

    // Complete the minimumBribes function below.
    static void minimumBribes(int[] q)
    {
        int minBribe = 0;
        for (int i = 0; i < q.Length; i++)
        {
            if (q[i] != i + 1 && q[i] != i + 2 && q[i] != i + 3)
            {
                Console.WriteLine("Too chaotic");
                break;
            }
            else if (q[i] == i + 2)
            {
                minBribe++;
            }
            else if (q[i] == i + 3)
            {
                minBribe = minBribe + 2;
            }

        }
        Console.WriteLine(minBribe);
    }

    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
            ;
            minimumBribes(q);
        }
    }
}
