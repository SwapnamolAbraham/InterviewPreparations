using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepartions
{
    internal class HourGlass
    {
        public void hourexample()
        {
            int[,] arr = {{1, 2, 3, 0, 0,0},
                       {0, 0, 0, 0, 0,0},
                       {2, 1, 4, 0, 0,0},
                       {0, 0, 0, 0, 0,0},
                       {1, 1, 0, 1, 0,0},
              {1, 1, 0, 1, 0,0}};
            int result = hourglassSum(arr);

            Console.WriteLine(result);


        }
        static int hourglassSum(int[,] arr)
        {
            int max = int.MinValue;
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    int sum = 0;
                    //sum += arr[i][j] + arr[i - 1][j - 1] + arr[i - 1][j] + arr[i - 1][j + 1] + arr[i + 1][j - 1] + arr[i + 1][j] + arr[i + 1][j + 1];
                    sum += arr[i,j] + arr[i - 1,j - 1] + arr[i - 1,j] + arr[i - 1,j + 1] + arr[i + 1,j - 1] + arr[i + 1,j] + arr[i + 1,j + 1];

                    if (sum > max)
                        max = sum;
                }
            }
            return max;
        }
    }

  
}
