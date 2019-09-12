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

    // Complete the minimumSwaps function below.
    static int minimumSwaps(int[] arr)
    {
        int minSwap = 0;
        int[] result = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            
            if (arr[i] == i + 1)
            {
                continue;
            }
            
            for(int k = i + 1; k < arr.Length; k++)
            {
                if (arr[k] == i+1)
                {
                    int temp = arr[k];
                    arr[k] = arr[i];
                    arr[i] = temp;
                    minSwap++;
                    break;
                }
            }

        }
        return minSwap;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@"C:\Users\nageshappag\Documents\Git\hackerrank_practice\write.txt", true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int res = minimumSwaps(arr);

        textWriter.WriteLine(res);

        textWriter.Flush();
        textWriter.Close();
    }
}
