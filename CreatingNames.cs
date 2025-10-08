using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_lab2
{
    internal class CreatingNames
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

        public CreatingNames(string firstName)
        {
            First = firstName;
            Last = "";
            Middle = "";
        }

        public CreatingNames(string firstName, string lastName)
        {
            First = firstName;
            Last = lastName;
            Middle = "";
        }

        public CreatingNames(string firstName, string lastName, string middleName)
        {
            First = firstName;
            Last = lastName;
            Middle = middleName;
        }

        public override string ToString()
        {
            string result = "";

            if (first != "")
            {
                result += first;
            }

            if (middle != "")
            {
                if (result != "") result += " ";
                result += middle;
            }

            if (last != "")
            {
                if (result != "") result += " ";
                result += last;
            }

            return result;
        }
    }
}
