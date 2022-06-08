namespace dotnet6_studentgrades.Models
{
    public class School : SchoolObjectBase
    {
        public string SchoolId { get; set; }
        public int FoundedYear { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public SchoolType SchoolType { get; set; }
        public List<Course> Courses { get; set; }

        public School(string name, int year) => (Name, FoundedYear) = (Name, year);

        public School(string name, int year,
                       SchoolType type,
                       string country = "", string city = "") : base()
        {
            (Name, FoundedYear) = (name, year);
            Country = country;
            City = city;
        }

        public School()
        {

        }
        public override string ToString()
        {
            return $"Name: \"{Name}\", Type: {SchoolType} {System.Environment.NewLine} Country: {Country}, City:{City}";
        }
    }    
}