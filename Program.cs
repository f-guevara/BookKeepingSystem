using System;



namespace BookKeepingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleUI ui = new ConsoleUI();
            Business business = new Business();

            while (true)
            {
                int choice = ui.GetUserChoice();

                switch (choice)
                {
                    case 1:
                        Book newBook = ui.GetBookDetails();
                        business.AddBook(newBook);
                        ui.ShowMessage("Book added successfully!\n");
                        break;

                    case 2:
                        string titleToDelete = ui.GetBookTitle();
                        business.DeleteBook(titleToDelete);
                        ui.ShowMessage("Book deleted successfully!\n");
                        break;

                    case 3:
                        var books = business.GetAllBooks();
                        ui.DisplayBooks(books);
                        break;

                    case 4:
                        return;

                    default:
                        ui.ShowMessage("Invalid option. Please try again.\n");
                        break;
                }
            }
        }
    }
}

