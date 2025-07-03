namespace Mylinq;



class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };

        bool allEven = numbers.All(n => n % 2 == 0);
        Console.WriteLine($"Четные: {allEven}");

        bool anyElements = numbers.Any();
        Console.WriteLine($"Есть элементы: {anyElements}");

        bool anyElementsN = numbers.Any(n => n > 3);
        Console.WriteLine($"Есть больше n: {anyElementsN}");

        int first = numbers.First();
        Console.WriteLine($"Первый элемент: {first}");

        int firstMoreN = numbers.First(n => n > 3);
        Console.WriteLine($"Первый > 3: {firstMoreN}");

        int firstOrDefault = numbers.FirstOrDefault();
        Console.WriteLine($"Первый или default: {firstOrDefault}");

        var emptyList = new List<int>();
        int firstOrDefaultEmpty = emptyList.FirstOrDefault();
        Console.WriteLine($"Первый или default: {firstOrDefaultEmpty}");

        int firstOrDefaultmore = numbers.FirstOrDefault(n => n > 5);
        Console.WriteLine($"Первый > 5 или default: {firstOrDefaultmore}");

        int firstOrDefaultValue = numbers.FirstOrDefault(n => n > 10, -1);
        Console.WriteLine($"Первый > 10 или -1: {firstOrDefaultValue}");

        foreach (var item in numbers.Where(n => n % 2 == 0))
        {
            Console.WriteLine($"Четный: {item}");
        }

        int count = numbers.Count();
        Console.WriteLine(count);

        int countEven = numbers.Count(n => n % 2 == 0);
        Console.WriteLine($"Чет: {countEven}");
    }
}