using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestKolekcija
{
    abstract class Student  : IComparable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int YearOfStudy { get; set; }

        public string Model { get; set; }
        public double Grade { get; set; }

        public int CompareTo(Student other)
        {
            if(other == null)
            {
                return 1;
            }
            else
            {
                return this.YearOfStudy.CompareTo(other.YearOfStudy);
            }
        }

        public string DisplayInfo()
        {
            return $"Id: {Id}, Name: {Name}, Year of Study: {YearOfStudy}, Model: {Model}, Grade: {Grade}";
        }

        public override string ToString()
        {
            return DisplayInfo();
        }
    }
}
