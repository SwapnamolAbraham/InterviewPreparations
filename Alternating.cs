using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepartions
{
    internal class Alternating
    {
        public int alternative(string s)
        {
            int result = 0;
            var c= 'z';
            
        for(int i=0; i < s.Length; i++)
            {
                if (s[i].Equals(c))
                    result++;
                c = s[i];
            }

            return result;
        }
    }
}
