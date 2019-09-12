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
     * Complete the 'arraySum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY numbers as parameter.
     */

    public static int arraySum(List<int> numbers)
    {
        int sum = 0;
        foreach (int i in numbers)
            sum = sum + i;
        return sum;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int numbersCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> numbers = new List<int>();

        for (int i = 0; i < numbersCount; i++)
        {
            int numbersItem = Convert.ToInt32(Console.ReadLine().Trim());
            numbers.Add(numbersItem);
        }

        int result = Result.arraySum(numbers);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
