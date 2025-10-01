namespace USFLibraryManagement
{
    // Inherits from Person
    public class Student : Person
    {
        public string Major;
        public int GraduationYear;

        public Student()
        {
            Major = "";
            GraduationYear = 0;
        }

        public static Student[] GetSampleStudents()
        {
            Student s1 = new()
            {
                Name = "Akhil",
                Email = "akhil@usf.edu",
                ID = "S001",
                Major = "Business Analytics",
                GraduationYear = 2026
            };

            Student s2 = new()
            {
                Name = "Sandeep",
                Email = "sandeep@usf.edu",
                ID = "S002",
                Major = "Information Systems",
                GraduationYear = 2025
            };

            return [s1, s2];
        }
    }
}