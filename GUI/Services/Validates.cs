using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Services
{
    public class Validates
    {
        public bool CheckEmpty(string txt)
        {
            if (string.IsNullOrEmpty(txt))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
