using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_lab2
{
    internal class PersonWithName
    {
        private Name name;
        private int height;

        public Name PersonName
        {
            get { return name; }
            set
            {
                if (value == null)
                    name = new Name("", "", "");
                else
                    name = value;
            }
        }

        public int Height
        {
            get { return height; }
            set
            {
                if (value < 0)
                    height = 0;
                else
                    height = value;
            }
        }

        public PersonWithName(Name personName, int personHeight)
        {
            PersonName = personName;
            Height = personHeight;
        }

        public override string ToString()
        {
            return $"{PersonName}, рост: {Height}";
        }
    }
}
