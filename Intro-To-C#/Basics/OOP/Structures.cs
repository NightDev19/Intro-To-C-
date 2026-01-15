using System;
using System.Collections.Generic;

namespace Intro_To_CSharp.Basics.OOP
{
    // Defining Structure
    struct Book
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
    // Using Structure on Parameterized Constructor
    struct Person
    {
        public string name;
        public int age;
        public string empid;

        public Person(string name , int age, string empid)
        {
            this.name = name;
            this.age = age;
            this.empid = empid;
        }
    }
    class People
    {
        public static void Demonstrate()
        {
            Person person1 = new Person("KJ", 24, "SEIII");
            Console.WriteLine($"Name: {person1.name}, Age: {person1.age}, EmpID: {person1.empid}");
            Person person2 = new Person("Alex", 30, "PM");
            Console.WriteLine($"Name: {person2.name}, Age: {person2.age}, EmpID: {person2.empid}");
        }
    }
    // Immutable Structure
    struct Animal
    {
        public readonly string name;
        public readonly string breed;
        public readonly string color;

        public Animal(string name, string breed, string color)
        {
            this.name = name;
            this.breed = breed;
            this.color = color;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Breed: {breed}, Color: {color}");
        }
    }
    class Pets
    {
        public static void Demonstrate()
        {
            Animal pet1 = new Animal("Buddy", "Golden Retriever", "Golden");
            Animal pet2 = new Animal("Mittens", "Siamese Cat", "Cream");
            pet1.DisplayInfo();
            pet2.DisplayInfo();
        }
    }

    internal class Structures
    {
        public static void Demonstrate()
        {
            Books.Demonstrate();
            People.Demonstrate();
            Pets.Demonstrate();

        }
    }
}