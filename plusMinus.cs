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

class plusMinus
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus1()
    {
        List<int> arr = new List<int> { -4, 3, - 9, 0, 4, 1 };
        
        int n = arr.Count();
        int postive_Count = 0;
        int negative_Count = 0;
        int zero_Count = 0;
        if (n >0 && n <=100)
        {
                     postive_Count = arr.OfType<int>().Where(n => (n > 0 && n <=100)).ToList().Count();
                     negative_Count = arr.OfType<int>().Where(n => (n < 0 && n >=-100)).ToList().Count();
                     zero_Count = arr.OfType<int>().Where(n => n == 0).ToList().Count();

            if (postive_Count > 0)
            {
                double positiveProp =(double) postive_Count / n;
                Console.WriteLine(String.Format("{0:0.000000}", positiveProp));
            }
            else
            {
                Console.WriteLine("0.000000");
            }
            if (negative_Count > 0)
            {
                double negativeProp = (double)negative_Count / n;
                Console.WriteLine(String.Format("{0:0.000000}", negativeProp));
            }

            else
            {
                Console.WriteLine("0.000000");
            }

            if (zero_Count > 0)
            {
                double zeroProp = (double)zero_Count / n;
                Console.WriteLine(String.Format("{0:0.000000}", zeroProp));
            }
            else
            {
                Console.WriteLine("0.000000");
            }
        }
    }

}


