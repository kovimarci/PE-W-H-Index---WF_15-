using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_15
{
    class Person
    {
        public int Height { get; set; }
        public int Weight { get; set; }
        public Person(string line)
        {
            string[] s = line.Split('-');
            Height = int.Parse(s[0]);
            Weight = int.Parse(s[1]);
        }
        public Person(int weight, int height)
        {
            Height = height;
            Weight = weight;
        }
        public Person()
        {
            Weight = 25;
            Height = 195;
        }
    }
}
