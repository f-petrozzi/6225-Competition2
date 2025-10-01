namespace USFLibraryManagement
{
        public class Staff : Person
    {
        public string Position;
        public string Department;

        public Staff()
        {
            Position = "";
            Department = "";
        }

        public static Staff[] GetSampleStaff()
        {
            Staff st1 = new()
            {
                Name = "Grandon Gill",
                Email = "grandon@usf.edu",
                ID = "ST001",
                Position = "Librarian",
                Department = "Library Services"
            };

            return [st1];
        }
    }
}