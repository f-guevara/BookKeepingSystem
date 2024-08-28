using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BookKeepingSystem
{
    public class ConsoleUI
    {
        public int GetUserChoice()
        {
            int choice;
            while (true)
            {
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Delete Book");
                Console.WriteLine("3. View All Books");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 4)
                {
                    return choice;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                }
            }
        }

        public Book GetBookDetails()
        {
            string title = GetStringInput("Enter Title: ");
            string author = GetStringInput("Enter Author: ");
            int year = GetYearInput("Enter Year: ");

            return new Book(title, author, year);
        }

        public string GetBookTitle()
        {
            return GetStringInput("Enter the title of the book: ");
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void DisplayBooks(List<Book> books)
        {
            Console.WriteLine("\nBooks in the library:");
            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.Year}");
            }
            Console.WriteLine();
        }

        private string GetStringInput(string prompt)
        {
            string input;
            while (true)
            {
                Console.Write(prompt);
                input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    return input.Trim();
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a non-empty value.");
                }
            }
        }

        private int GetYearInput(string prompt)
        {
            int year;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out year) && year > 0)
                {
                    return year;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid year (e.g., 2023).");
                }
            }
        }
    }
}

