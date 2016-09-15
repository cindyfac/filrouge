using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DAO
{
    class verification
    {
        public void verifstring(string S)
        {
                try
                {
                    Regex.IsMatch(S, @"^[a-zA-Z]+$");
                }
                catch(FormatException)
                {
                    
                }
         
           

        }
    }
}
