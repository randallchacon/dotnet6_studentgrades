using System;

namespace dotnet6_studentgrades.Models
{
    public class Evaluation : SchoolObjectBase
    {
        public Student Student { get; set; }
        public Student Subject  { get; set; }

        public float Grade { get; set; }

        public override string ToString()
        {
            return $"{Grade}, {Student.Name}, {Subject.Name}";
        }
    }
}