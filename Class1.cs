using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepartions
{
   public class Class1
    {
        public virtual double milestokmf { get { return 1.609; } }
        public double milestokm(double miles)
        {
            return this.milestokmf * miles;

        }

    }
    public class m1 : Class1
    {
        public override double milestokmf { get { return 1.869; } }
    }
}
