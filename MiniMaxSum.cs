using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace InterviewPrepartions
{
    class MiniMaxSum
    {
        public static void miniMaxSum1()
        {
            List<int> arr = new List<int> { 256741038, 623958417, 467905213, 714532089, 938071625 };
            int n = arr.Count();
           

          if(n >0)
            {
               // List<long> newarry = arr.ToList();
                arr.Sort();
               // long maxSum = (long) (newarry.Sum())- (long)newarry[0];
               /// long minSum = (long)newarry.Sum() - (long)newarry[n-1];

               // Console.WriteLine(minSum + " " + maxSum);
                Console.WriteLine(String.Format("{0} {1}", arr.Take(4).Sum(), arr.TakeLast(4).Sum()));
            }

        }
    }
}
