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

    // Complete the countingValleys function below.
    static int countingValleys(int n, string s)
    {
        int vCount = 0;
        bool isValley = false;
        bool isMountain = false;
        bool isNewValley = true;
        int level = 0;
        foreach (char c in s)
        {

            if (c == 'D')
            {
                level--;
            }
            else if (c == 'U')
            {
                level++;
            }
            if (level == 0)
            {
                isValley = isMountain = false;
                isNewValley = true;
            }
            else if (level < 0)
            {
                isValley = true;
                isMountain = false;
            }
            else if (level > 0)
            {
                isValley = false;
                isMountain = true;
            }

            if (!isMountain && isValley && isNewValley)
            {
                vCount++;
                isNewValley = false;
            }
        }

        return vCount;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@"C:\Users\nageshappag\Documents\Git\hackerrank_practice\write.txt", true);

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        int result = countingValleys(n, s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
