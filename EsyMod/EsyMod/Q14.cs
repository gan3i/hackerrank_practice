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

class Result
{

    /*
     * Complete the 'countNonUnique' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY numbers as parameter.
     */

    public static int countNonUnique(List<int> numbers)
    {
        int count = 0;
        int[] checkedele = new int[numbers.Count+1];

        foreach(int i in numbers)
        {
            int count1 = 0;
            if (!checkedele.Contains(i))
            {
                foreach (int k in numbers)
                {

                    if (i == k)
                        count1++;
                    if (count1 >= 2)
                    {
                        checkedele[i] = i;
                        count++;
                        break;
                    }


                }
            }
        }

        return count;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@"C:\Users\nageshappag\Documents\Git\hackerrank_practice\write.txt", true);

        int numbersCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> numbers = new List<int>();

        for (int i = 0; i < numbersCount; i++)
        {
            int numbersItem = Convert.ToInt32(Console.ReadLine().Trim());
            numbers.Add(numbersItem);
        }

        int result = Result.countNonUnique(numbers);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
