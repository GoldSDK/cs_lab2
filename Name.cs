using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_lab2
{
    public class Name
    {
        private string last;
        private string first;
        private string middle;

        public string Last
        {
            get { return last; }
            set
            {
                if (value == null)
                    last = "";
                else
                    last = value;
            }
        }

        public string First
        {
            get { return first; }
            set
            {
                if (value == null)
                    first = "";
                else
                    first = value;
            }
        }

        public string Middle
        {
            get { return middle; }
            set
            {
                if (value == null)
                    middle = "";
                else
                    middle = value;
            }
        }

        public Name(string lastName, string firstName, string middleName)
        {
            Last = lastName;
            First = firstName;
            Middle = middleName;
        }

        public override string ToString()
        {
            string result = "";

            if (last != "")
            {
                result += last;
            }

            if (first != "")
            {
                if (result != "") result += " ";
                result += first;
            }

            if (middle != "")
            {
                if (result != "") result += " ";
                result += middle;
            }

            return result;
        }
    }
}
