namespace USFLibraryManagement
{
    public class Book
    {
        public string Title;
        public string Author;
        public string ISBN;
        public int AvailableCopies;
        
        public Book()
        {
            Title = "";
            Author = "";
            ISBN = "";
            AvailableCopies = 0;
        }

        public bool BorrowBook()
        {
            if (AvailableCopies > 0)
            {
                AvailableCopies--;
                return true;
            }
            return false;
        }

        public void ReturnBook()
        {
            AvailableCopies++;
        }

        public static Book[] GetSampleBooks()
        {
            Book b1 = new()
            {
                Title = "The Art of Data Strategy",
                Author = "Liam Reynolds",
                ISBN = "ISBN111",
                AvailableCopies = 4
            };

            Book b2 = new()
            {
                Title = "Business Insights with AI",
                Author = "Olivia Carter",
                ISBN = "ISBN222",
                AvailableCopies = 3
            };

            Book b3 = new()
            {
                Title = "Analytics in Action",
                Author = "Nathan Brooks",
                ISBN = "ISBN333",
                AvailableCopies = 6
            };

            return [b1, b2, b3];
        }
    }
}