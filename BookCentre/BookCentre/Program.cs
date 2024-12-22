using System;
using System.Collections.Generic;

class Program
{
    static List<Book> books = new List<Book>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Добро пожаловать в библиотеку!");
            Console.WriteLine("1. Добавить книгу");
            Console.WriteLine("2. Удалить книгу");
            Console.WriteLine("3. Показать все книги");
            Console.WriteLine("4. Выход");
            Console.Write("Ваш выбор: ");
            string choice = Console.ReadLine();

            if (choice == "1") AddBook();
            else if (choice == "2") RemoveBook();
            else if (choice == "3") ShowBooks();
            else if (choice == "4") break;
            else Console.WriteLine("Неверный выбор. Попробуйте снова.");
        }
    }

    static void AddBook()
    {
        Console.Write("Введите название книги: ");
        string title = Console.ReadLine();
        Console.Write("Введите автора книги: ");
        string author = Console.ReadLine();
        Console.Write("Введите год выпуска: ");
        int year = int.Parse(Console.ReadLine());

        books.Add(new Book(title, author, year));
        Console.WriteLine("Книга добавлена!\n");
    }

    static void RemoveBook()
    {
        ShowBooks();
        Console.Write("Введите номер книги для удаления: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < books.Count)
        {
            books.RemoveAt(index);
            Console.WriteLine("Книга удалена!\n");
        }
        else
        {
            Console.WriteLine("Неверный номер книги.\n");
        }
    }

    static void ShowBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("Нет книг в библиотеке.\n");
        }
        else
        { 
            Console.WriteLine("Список книг:");
            for (int i = 0; i < books.Count; i++) 
                Console.WriteLine($"{i + 1}. {books[i]}");
            
            
            Console.WriteLine();
        }
    }
}
