namespace USFLibraryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new();

            foreach (Book b in Book.GetSampleBooks())
            {
                library.AddBook(b);
            }

            foreach (Student s in Student.GetSampleStudents())
            {
                library.AddPatron(s);
            }

            foreach (Staff st in Staff.GetSampleStaff())
            {
                library.AddPatron(st);
            }

            library.DisplayBooks();
            library.DisplayPatrons();

            Console.WriteLine("Borrowing Books...");
            library.BorrowBook("S002", "ISBN222"); // Sandeep borrows Business Insights with AI
            library.BorrowBook("S001", "ISBN333"); // Akhil borrows Analytics in Action
            Console.WriteLine();

            Console.WriteLine("Books after borrowing:");
            library.DisplayBooks();
        }
    }
}