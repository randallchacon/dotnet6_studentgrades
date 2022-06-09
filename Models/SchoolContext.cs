using dotnet6_studentgrades.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet6_studentgrades{
    public class SchoolContext : DbContext{
        public DbSet<School> Schools {get; set;}
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }

        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var school = new School(){
                FoundedYear = 2022,
                Id = Guid.NewGuid().ToString(),
                Name = ".NET School",
                City = "San José",
                Country = "Costa Rica",
                Address = "Central Avenue",
                SchoolType = SchoolType.Secondary
            };

            modelBuilder.Entity<School>().HasData(school);

            modelBuilder.Entity<Subject>().HasData(
                new Subject{Name="Finance", Id= Guid.NewGuid().ToString()},
                new Subject{Name="Data bases", Id= Guid.NewGuid().ToString()},
                new Subject{Name="Web programming", Id= Guid.NewGuid().ToString()},
                new Subject{Name="HTML and CSS", Id= Guid.NewGuid().ToString()},
                new Subject{Name="Security", Id= Guid.NewGuid().ToString()}
            );  

            modelBuilder.Entity<Student>().HasData(GenerateStudents().ToArray());                      
        }

        private List<Student> GenerateStudents()
        {
            string[] name1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] lastName = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] name2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var studentList = from n1 in name1
                               from n2 in name2
                               from a1 in lastName
                               select new Student { 
                                   Name = $"{n1} {n2} {a1}" ,
                                   Id = Guid.NewGuid().ToString()
                                   };

            return studentList.OrderBy((al) => al.Id).ToList();          
        }          
    }
}