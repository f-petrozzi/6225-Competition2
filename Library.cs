using System;
using System.Collections.Generic;

namespace USFLibraryManagement
{
    public class Library
    {
        public List<Book> Books = [];
        public List<Person> Patrons = [];

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void AddPatron(Person person)
        {
            Patrons.Add(person);
        }

        public void DisplayBooks()
        {
            Console.WriteLine("Books in Library:");
            foreach (Book b in Books)
            {
                Console.WriteLine("Title: " + b.Title + ", Author: " + b.Author + ", Available Copies: " + b.AvailableCopies);
            }
            Console.WriteLine();
        }

        public void DisplayPatrons()
        {
            Console.WriteLine("Patrons in Library:");
            foreach (Person p in Patrons)
            {
                Console.WriteLine("Name: " + p.Name + ", ID: " + p.ID);
            }
            Console.WriteLine();
        }

        public bool BorrowBook(string patronId, string isbn)
        {
            Person? patron = null;
            foreach (Person p in Patrons)
            {
                if (p.ID == patronId)
                {
                    patron = p;
                    break;
                }
            }

            Book? book = null;
            foreach (Book b in Books)
            {
                if (b.ISBN == isbn)
                {
                    book = b;
                    break;
                }
            }

            if (patron == null || book == null)
            {
                return false;
            }

            bool ok = book.BorrowBook();
            if (ok)
            {
                Console.WriteLine(patron.Name + " borrowed '" + book.Title + "'");
                return true;
            }

            return false;
        }

        public bool ReturnBook(string patronId, string isbn)
        {
            Person? patron = null;
            foreach (Person p in Patrons)
            {
                if (p.ID == patronId)
                {
                    patron = p;
                    break;
                }
            }

            Book? book = null;
            foreach (Book b in Books)
            {
                if (b.ISBN == isbn)
                {
                    book = b;
                    break;
                }
            }

            if (patron == null || book == null)
            {
                return false;
            }

            book.ReturnBook();
            Console.WriteLine(patron.Name + " returned '" + book.Title + "'");
            return true;
        }
    }
}