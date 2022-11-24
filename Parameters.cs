using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepartions
{
    public class Parameters
    {
        public void invoke (object S)
        {
            Console.WriteLine("object param is invoked");
        }
        public void invoke<T>(params T[]  values)
        {
            Console.WriteLine("param method is invoked");
        }

    }
}
