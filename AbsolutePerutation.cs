using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepartions
{
    internal class AbsolutePerutation
    {
        public int[] absPermutaion(int n, int k)
        {
            var result = new int[n];
            if (k == 0)
            {
                return new[] { -1 };
            }
            else if(n%2 ==0)
            {
                return new[] { -1 };
            }
            else
            {
                for(int j=1;j<(n-k+1);j++)
                {
                    if (result[j] == result[j+k]-k)
                    {
                        var temp = result[j];
                        result[j] = result[j+k];
                        result[j+k] = temp;
                    }
                    else if (Math.Abs(j-result[j]) !=k)
                        return new[] { -1 };
                }

                for(int j=(n-k+1);j<(n+1);j++)
                {
                    if(Math.Abs(j-result[j]) !=k)
                        return new[] { -1 };
                }

                return result;
            }

        }
    }
}
