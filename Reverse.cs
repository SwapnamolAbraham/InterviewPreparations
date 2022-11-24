using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepartions
{
    class Reverse
    {

        //public static List<int> reverseArray()
        //{

        //List<int> arr = new List<int> { 1,3,2,4,5 };
        //int n = arr.Count();
        //List<int> Newarr = null;

        //if (n > 0 && n<=100)
        //{
        //    Newarr = arr.OfType<int>().Where(n => (n > 0 && n <= 100)).ToList();
        //    Newarr.Sort();
        //    Newarr.Reverse();
        //}

        //return Newarr;

        public static int minOperations()
        {
            List<int> arr = new List<int> { 2, 1, 2, 3, 4, 5, 2, 9 };
            int n = arr.Count();
            int LHCount = 0;
            int RHCount = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (i % 2 == 0)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        LHCount++;
                    }
                }
                else
                {
                    if (arr[i] < arr[i + 1])
                    {
                        LHCount++;
                    }

                }
            }
            return n;
        }
    }
}
