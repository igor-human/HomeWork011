using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class Car
    {
        private string Name { get; set; }
        private int Year { get; set; }

        public Car(string name, int year)
        {
            Name = name;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Name} ({Year})";
        }
    }
}
