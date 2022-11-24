using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace InterviewPrepartions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question:
            // Given an array of integers, write a function that will return a boolean that determines if the array is sorted, lowest to highest. 

            // Function should return true or false in the following cases:
            // [-1, 0, 1]: return true (successful test)
            // [-1, 3, 10, 10]: return true (successful test)
            // [1, 1, 1]: return true (successful test)
            // [0, -1]: return false (successful test)
            // [0]: return true (successful test)
            // [-1, -3]: return false (successful test)
            // []: return true (successful test)
            // [-1, 0, 1, 10, 9]: return false (successful test)
            //int[] arrayToTest = { 20, 23, 15, 45, 78, 88 };
            //bool isSorted = isSortedArray(arrayToTest);
            //Console.WriteLine("Input Array" + arrayToTest);
            //if (!isSorted)
            //    Console.WriteLine("returned false");
            //else
            //    Console.WriteLine("returned true;");


            //// Question:
            //// Given a string containing a set of words separated by whitespace, we would like to transform it to a string in which the words appear in the reverse order.
            //// For example, "Alice likes Bob" transforms to "Bob likes Alice". We do not need to keep the original string.

            //// Tests to pass:
            //// 'Frank' returns 'Frank' (test passed)
            //// '' returns '' (test passed)
            //// 'Alice likes Bob' returns 'Bob likes Alice' (test passed)
            //// initially, we will ignore punctuation. So the following will be initial results:
            //// 'Alice, do you like Bob?' returns 'Bob? like you do Alice,' (test passed)
            //// ',' returns ',' (test passed)
            //// ', ?' returns '? ,' (test passed)

            //string strText = ", ?";
            //string reversedString = ReversedString(strText);

            //Console.WriteLine(strText);
            //Console.WriteLine(reversedString);


            //Question:
            //Write a program that outputs the first 6 lines of Pascal's Triangle. 

            //1 
            //1 1 
            //1 2 1 
            //1 3 3 1 
            //1 4 6 4 1 
            //1 5 10 10 5 1

            //Each row begins and ends with the number one. The remaining numbers are obtained by summing the two numbers that lie directly above that number on the previous row and the number that preceeds it. So, in order to find the numbers in the nth row of the triangle, we need the values of the (n-1) the row. Let's say that we have computed the fourth row - 1 3 3 1. Now, the fifth row has five elements. The first and the last element would be one. The remaining elements would be (1+3), (3+3), (3+1) = 4, 6, 4. So, the complete fifth row would be 1 4 6 4 1.

            // A generic pascal's triangle function would accept a number of lines, and pass the following tests:
            // (in all cases below, we are just showing the last row, but a correct result would include all prior rows)
            // 1 returns [1] (passed)
            // 2 returns [1, 1] (which is result of [1, 1]) (passed)
            // 3 returns [1, 2, 1] (which is result of [1, (1 + 1), 1] (passed)
            // 4 returns [1, 3, 3, 1] (which is result of [1, (2+1), (1+2), 1]) (passed)
            // 5 returns [1, 4, 6, 4, 1] (which is result of [1, (3 + 1), (3 + 3), (1 + 3), 1] (passed)
            // 6 returns [1, 5, 10, 10, 5, 1] (which is result of [1, (4 + 1), (6 + 4), (4 + 6), (1 + 4), 1] (passed)
            // 0 returns undefined (passed)

            // this function will just build the triangle, another function will print it out - keep out side effects

            //Console.WriteLine("Number of lines");
            //var input = Console.ReadLine();
            //int number = Convert.ToInt32(input);
            //createPascal(number);

            //int[] arr = { 1, 2, 3, 4,5 };
            //sum(arr);
            //string str = "swapna";
            //Boolean result = palindrome(str);

            //int[] arr = { 5, 5,6,3,7,5,5 };
            //int index = FindCoveringPrefix(arr);
            //Console.WriteLine(index);

            //Console.WriteLine("value" + new Class1().milestokm(1));
            // Console.WriteLine("value1" + ((Class1)new m1()).milestokm(1));
            //Console.WriteLine("value1" + ((mammal)new Bear()).MakeSound());
            //mammal ma = new Bear();

            //ma.MakeSound();
            //ma.numberofLegs();
            //Bear b = new Bear();
            //b.MakeSound();
            //b.numberofLegs();
            //animal a = new Bear();

            string s = "example";
            Parameters parameters = new Parameters();
            parameters.invoke(s);
            Console.WriteLine("animal");

            //Products product = new Products("ssss",(10));
            //Console.WriteLine(product.Name);
            //Console.WriteLine(product.Quantity);

            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //Snapshot snap = new Snapshot(list);
            //list[0] = 3;
            //list = snap.Restore();
            //Console.WriteLine(string.Join(", ", list)); //It should log "1, 2"
            //list.Add(4);
            //list = snap.Restore();
            //Console.WriteLine(string.Join(", ", list)); //It should log "1, 2"


            // Should print "flo", "fle", and "fla" since those are the distinct, length 3 prefixes.
            //foreach (var p in AllPrefixes(3, new string[] { "flow", "flowers", "flew", "FLAG", "fm" }))
            //    Console.WriteLine(p);

            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            //List<int> arr = new List<int>();

            //for (int i = 0; i < arrCount; i++)
            //{
            //    int arrItem = Convert.ToInt32(Console.ReadLine().Trim());
            //    arr.Add(arrItem);
            //}

            //int k = Convert.ToInt32(Console.ReadLine().Trim());

            //string result = Result.findNumber(arr, k);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();

            //HourGlass hrglasss = new HourGlass();
            // hrglasss.hourexample();

            //AbsolutePerutation ap = new AbsolutePerutation();
            //int[] res = ap.absPermutaion(4,2 );

            //Alternating al = new Alternating();
            //al.alternative("AAA");
            // Result r = new Result();
            //int res = r.sockMerchant();
            // Console.WriteLine(res);



            //plusMinus.plusMinus1();
            // MiniMaxSum.miniMaxSum1();
            // int n=   Reverse.minOperations();

            // Console.WriteLine(n);
        }

        public static IEnumerable<string> AllPrefixes(int prefixLength, IEnumerable<string> words)
        {

            //IEnumerable<string> prefixes = words.Where(p => p.Length >= prefixLength).Select(p => p.Substring(0, prefixLength)).Distinct();
            IEnumerable<string> prefixes =  words.Where(p => p.Length >= prefixLength).Select(p => p.ToLower().Substring(0, prefixLength));
            return prefixes.Distinct();
            
        }

        static int FindCoveringPrefix(int[] arr)
        {
            int index=0;

            int[] distinctArray = arr.Distinct().ToArray();

            for (int i =0; i< distinctArray.Length; i++)
            {
                 int newindex = Array.IndexOf(arr, distinctArray[i]);
                if (index < newindex)
                    index = newindex;              
            }
        
            return index;
        }

        static Boolean palindrome(string str)
        {
            if (str!= null)
            {
                string reverseString = new string(str.Reverse().ToArray());
                if (reverseString.ToLower() == str.ToLower())
                {
                    Console.WriteLine("String is palibdrome");
                    return true;
                }
            }
            Console.WriteLine("String is not palibdrome");
            return false;

        }

        static void sum(int[] arr)
        {
            int sum = 0;
            if (arr != null)
            {
                sum = arr.Sum();
                Console.WriteLine(sum);
            }
        }


        static public bool isSortedArray(int[] arrayToTest)
        {

            if (arrayToTest != null)
            {
                if (arrayToTest.Length == 1)
                    return true;
                else
                {
                    //Array.Sort(arrayToTest);
                    // arrayToTest.SequenceEqual(sortedArray)
                    for (var i = 0; i < arrayToTest.Length; i++)
                    {
                        if (arrayToTest[i] > arrayToTest[i + 1])
                        {
                            return false;
                        }
                    }
                }
            }
            
            return true;
        }

        static string ReversedString(string strText)
        {
            if( strText!= "")
            {
             string[] splittedString =   strText.Split(' ');
              Array.Reverse(splittedString);
               string s1 = string.Join(" ", splittedString);
                return s1;
            }
            return "";
        }

        static void createPascal(int num)
        {
            if(num ==1 )
            Console.WriteLine("1");
            else if (num ==2)
            {
                Console.WriteLine("1 1");
            }
            else
            {
                for (int i = 3; i <=num;i++)
                {
                    
                }
            }
        }
    }
}
