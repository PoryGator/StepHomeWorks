using IEnumerable;
using IEnumerable.obj;
using IEnumerable.Models;

var PhoneBook = new PhoneBook();
PhoneBook.Numbers.Add(new PhoneNumber("512365", "Bob", "Marley", Gender.Mr));
PhoneBook.Numbers.Add(new PhoneNumber("122435", "Ann", "Brown", Gender.Ms));
PhoneBook.Numbers.Add(new PhoneNumber("434223", "John", "White", Gender.Mr));


PhoneBook.EnumMode = ModeEnum.SortedByNumber;
foreach (var item in PhoneBook)
{
    System.Console.WriteLine($"{item.Person.Gender} {item.Person.Name} {item.Person.Surname} {item.Number}");
}

System.Console.WriteLine();
PhoneBook.EnumMode = ModeEnum.SortedByName;
foreach (var item in PhoneBook)
{
    System.Console.WriteLine($"{item.Person.Gender} {item.Person.Name} {item.Person.Surname} {item.Number}");
}