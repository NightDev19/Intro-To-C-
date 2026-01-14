using System;
using System.Collections.Generic;

namespace Intro_To_CSharp.Basics.OOP
{
    public struct Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Subject { get; set; }
        public int BookId { get; set; }

        public Book(string title, string author, string subject, int bookId)
        {
            Title = title;
            Author = author;
            Subject = subject;
            BookId = bookId;
        }

        public override string ToString()
        {
            return $"Title: {Title}\n" +
                   $"Author: {Author}\n" +
                   $"Subject: {Subject}\n" +
                   $"Book ID: {BookId}";
        }
    }

    class Books
    {
        public static void Demonstrate()
        {
            // Dictionary with book ID as key and Book struct as value
            var books = new Dictionary<int, Book>
            {
                {
                    6495407,
                    new Book(
                        title: "C# Programming",
                        author: "Tan Ah Teck",
                        subject: "C# Programming Tutorial",
                        bookId: 6495407
                    )
                },
                {
                    6495700,
                    new Book(
                        title: "Telecom Billing",
                        author: "Zara Ali",
                        subject: "Telecom Billing Tutorial",
                        bookId: 6495700
                    )
                }
            };

            // Print all books
            foreach (var kvp in books)
            {
                Console.WriteLine($"Book {kvp.Key}:");
                Console.WriteLine(kvp.Value);
                Console.WriteLine();
            }

            // Alternative: Access specific books by ID
            if (books.TryGetValue(6495407, out Book book1))
            {
                Console.WriteLine("Accessing Book 1 directly:");
                Console.WriteLine(book1);
            }
        }
    }
    internal class Structures
    {
       
        public static void Demonstrate()
        {
            Books.Demonstrate();
        }
    }
}