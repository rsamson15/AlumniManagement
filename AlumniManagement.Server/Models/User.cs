namespace AlumniManagement.Server.Models
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string CurrentJobTitle { get; set; }
        public string Organization { get; set; }
        public string ProfileImage { get; set; }
        public string GraduationYear { get; set; }
        public string GraduationSemester { get; set; }
        public string GithubProfile { get; set; }
        public string LinkedInProfile { get; set; }
        public bool LookingForMentor { get; set; }
        public UserType UserType { get; set; }
        public string Password { get; set; }

    }
}
