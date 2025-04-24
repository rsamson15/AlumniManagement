using Microsoft.EntityFrameworkCore;

namespace AlumniManagement.Server.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) :
    base(options)
        { }
        public DbSet<User> User { get; set; }   // add a a login migration?
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
            new User { ID = 1, FirstName = "Zaros", LastName = "Marshall", Email = "zmarshall@gmail.com", PhoneNumber = "000-000-0000", 
                CurrentJobTitle = "QA Engineer", Organization = "Pet Smart", ProfileImage = "", GraduationYear = "2020", 
                GraduationSemester = "Spring",GithubProfile = "zmarsh01", LinkedInProfile = "ZarosMarshall", LookingForMentor = true, UserType = UserType.student, Password = ""},
            new User{ ID = 2, FirstName = "Olivia",LastName = "Samson",Email = "osamson@gmail.com",PhoneNumber = "111-111-1111",
                CurrentJobTitle = "Software Engineer",Organization = "Bee Inc.",ProfileImage = "",GraduationYear = "2021",
                GraduationSemester = "Fall", GithubProfile = "osams02", LinkedInProfile = "OliviaMarshall",LookingForMentor = true,UserType = UserType.student, Password= ""},
            new User { ID = 3,FirstName = "Rose", LastName = "Tyler", Email = "rtyler@gmail.com", PhoneNumber = "222-222-2222",
                CurrentJobTitle = "College Administrator", Organization = "Augusta Technical College", ProfileImage = "", GraduationYear = 
                "1998", GraduationSemester = "Summer", GithubProfile = "rtyler78", LinkedInProfile = "RoseTyler", LookingForMentor = false, UserType = UserType.admin, Password = ""},
            new User{ ID = 4, FirstName = "Amy", LastName = "Pond", Email = "apond@gmail.com", PhoneNumber = "444-444-4444",
                CurrentJobTitle = "College Administrator", Organization = "Augusta Technical College", ProfileImage = "", GraduationYear = 
                "1999", GraduationSemester = "WInter", GithubProfile = "apond55", LinkedInProfile = "AmyPond", LookingForMentor = false, UserType = UserType.admin, Password = ""},
            new User{ID = 5, FirstName = "Maria", LastName = "Santos", Email = "msantos@gmail.com", PhoneNumber = "555-555-5555",
                CurrentJobTitle = "Scrum Master", Organization = "Orange.Inc", ProfileImage = "", GraduationYear = "2010", 
                GraduationSemester = "Spring", GithubProfile = "msantos8", LinkedInProfile = "MariaSantos", LookingForMentor = false, UserType = UserType.mentor , Password = ""},
            new User{ ID = 6, FirstName = "Jose", LastName = "Cruz", Email = "jcruz@gmail.com", PhoneNumber = "777-777-7777",
                CurrentJobTitle = "Project Mnager", Organization = "Text.Inc", ProfileImage = "", GraduationYear = "2011",
                GraduationSemester = "Fall", GithubProfile = "jcruz11", LinkedInProfile = "JoseCruz", LookingForMentor = false, UserType = UserType.mentor, Password = ""}
            );
        }
    }
}
