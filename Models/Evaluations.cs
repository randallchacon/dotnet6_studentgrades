using System;

namespace dotnet6_studentgrades.Models
{
    public class Evaluations
    {
        public string UniqueId { get; set; }
        public string Name { get; set; }
        public Student Student { get; set; }
        public Student Subject { get; set; }
        public float Grade { get; set; }
        public Evaluations() => UniqueId = Guid.NewGuid().ToString();
    }
}