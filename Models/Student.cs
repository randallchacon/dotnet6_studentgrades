using System;
using System.Collections.Generic;
using dotnet6_studentgrades.Models;

namespace dotnet6_studentgrades.Models
{
    public class Student: SchoolObjectBase
    {
        public List<Evaluation> Evaluations { get; set; } = new List<Evaluation>();
    }
}