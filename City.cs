using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_lab2
{
    internal class City
    {
        public string name { get; set; }
        public City[] cities { get; set; }
        public int[] costs { get; set; }
        public int count { get; set; }

        public City(string Name)
        {
            name = Name;
            cities = new City[10];
            costs = new int[10];
            count = 0;
        }

        public void add(City city, int cost)
        {
            if (count < cities.Length)
            {
                cities[count] = city;
                costs[count] = cost;
                count++;
            }
        }

        public override string ToString()
        {
            string result = name + ": ";

            for (int i = 0; i < count; i++)
            {
                result += "(" + cities[i].name + ":" + costs[i] + ") ";
            }

            return result;
        }
    }
}
