using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepartions
{
    public class Product
    {
        string name;
        int quantity;

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                // Can only be called in this class.
                this.name = value;
            }
        }

        public int Quantity
        {
            get
            {
                return this.Quantity;
            }
            set
            {
                if (value < 0) // if less than zero debit account by 10
                {
                    Quantity = 1;
                }
                else
                {
                    Quantity = value;
                }
            }
        }

        public Product(string name,int quantity)
        {
            this.name = name;
            this.quantity = quantity;
        }
    }
}
