using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkInClass
{
    internal class Book
    {
        

        public string name;
        public string author;
        public double _price;
       
        public double Price 
        {
            get
            {
                return _price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("XXX");
                }
                this._price = value;
            }
        }
        

    }
}
