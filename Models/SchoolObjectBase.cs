using System;

namespace dotnet6_studentgrades.Models
{
    public abstract class SchoolObjectBase
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public SchoolObjectBase()
        {
            
        }

        public override string ToString()
        {
            return $"{Name},{Id}";
        }
    }
}