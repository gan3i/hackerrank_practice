using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Module
{
    class StockCount
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@"C:\Users\nageshappag\Documents\Git\hackerrank_practice\write.txt", true);

            int n = Convert.ToInt32(Console.ReadLine());
            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int result = sockMerchant(n, ar);

            textWriter.WriteLine(result);
            textWriter.Flush();
            textWriter.Close();
        }

        private static int sockMerchant(int n, int[] ar)
        {
            Array.Sort(ar);
            int sockPairCount = 0;
            int k = 0;
            while (k < n - 1)
            {
                if (ar[k] == ar[k + 1])
                {
                    sockPairCount++;
                    k = k + 2;
                }
                else
                {
                    k++;
                }
            }
            return sockPairCount;
        }


    }
}
