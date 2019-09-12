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
     * Complete the 'lastLetters' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING word as parameter.
     */

    public static string lastLetters(string word)
    {
        StringBuilder sB = new StringBuilder();

        char[] c = word.ToCharArray();
        for (int i = c.Length - 1; i >= (c.Length - 2); i--)
        {
            if (i == c.Length - 1)
            {
                sB.Append(c[i].ToString());
                sB.Append(" ");
            }
            else
            {
                sB.Append(c[i].ToString());
            }
            
        }
        

        return sB.ToString();

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string word = Console.ReadLine();

        string result = Result.lastLetters(word);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
