using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo
{
    class Palindrome
    {
        public bool isPalinddrome(String data)
        {
            if (data.Length < 2)
            {
                return true;
            }

            char first = data[0];
            char last = data[data.Length - 1];

            if (first != last)
            {
                return false;
            }

            // remove first character
            data = data.Remove(0, 1);
            // remove last character
            data = data.Remove(data.Length - 1, 1);

           // recursive
            bool check = isPalinddrome(data);
            return check;

        }
    }
}
