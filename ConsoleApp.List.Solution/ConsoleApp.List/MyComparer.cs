using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.List
{
    class MyComparer:IComparer
    {
        public int Compare(object x, object y)
        {
            if (x?.ToString()?.Length > y?.ToString()?.Length)
            {
                return 1;
            }
            else if (x?.ToString()?.Length < y?.ToString()?.Length)
            {
                return -1;
            }
            else if (x == null && y == null)
            {
                return 0;
            }
            else if (x == null && y != null)
            {
                return -1;
            }
            else if (x != null && y == null)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        
            
        
    }
}
