using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_lab2
{
    internal class Cat
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (value == null)
                    name = "";
                else
                    name = value;
            }
        }

        public Cat(string catName)
        {
            Name = catName;
        }

        public override string ToString()
        {
            return $"кот: {Name}";
        }

        public void Meow()
        {
            Console.WriteLine($"{Name}: мяу!");
        }

        public void Meow(int count)
        {
            string meows = "";
            for (int i = 0; i < count; i++)
            {
                if (meows != "") meows += "-";
                meows += "мяу";
            }
            meows += "!";

            Console.WriteLine($"{Name}: {meows}");
        }
    }
}
