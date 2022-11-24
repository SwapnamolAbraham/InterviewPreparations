using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepartions
{
   public abstract class animal
    {
        public abstract string MakeSound();
    }
    public abstract class mammal : animal
    {
        public override string MakeSound()
        {
            Console.WriteLine("nothing");
            return "";
        }
        public int numberofLegs()
        {
            Console.WriteLine("4");
            return 4;
        }
    }

    public class Bear : mammal
    {
        public override string MakeSound()
        {
            Console.WriteLine("roar");
            return "roar!";
        }
    }

    public class Falcon : animal
    {
        public override string MakeSound()
        {
            Console.WriteLine("shreik");
            return "shreik!";
        }
    }


}
