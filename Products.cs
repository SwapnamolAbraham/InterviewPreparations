using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrepartions
{
    class Products
    {
        public int nM;
        public Products(int nm,string name, int quantity)
        {
            nM = nm;
            this.name = name;
            this.quantity = quantity;
        }
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
                if (this.quantity < 0) // if less than zero debit account by 10
                {
                    this.quantity = 1;
                }
                return this.quantity;
               
            }
            set
            { 
                //if (value < 0) // if less than zero debit account by 10
                //{
                //    Quantity = 1;
                //}
                //else
                //{
                //    Quantity = value;
                //}
            }
        }

    }
}
