using System;
using System.Collections.Generic;
using System.IO;

public class Calculator
{
    private static List<ICalculatorOperation> operations = new List<ICalculatorOperation>()
    {
        new Addition(),
        new Subtraction(),
        new Multiplication(),
        new Division()
    };

    public void Start()
    {
        while (true)
        {
            try
            {
                Console.Clear();
                ShowOperations();
                Console.WriteLine("Выберите операцию (введите номер):");
                string input = Console.ReadLine();
                if (input.ToLower() == "exit") break;

                int operationIndex;
                if (!int.TryParse(input, out operationIndex) || operationIndex < 1 || operationIndex > operations.Count)
                {
                    Console.WriteLine("Некорректный номер операции. Попробуйте снова.");
                    continue;
                }

                ICalculatorOperation selectedOperation = operations[operationIndex - 1];

                Console.WriteLine($"Вы выбрали: {selectedOperation.Name}");
                Console.WriteLine("Введите первое число:");
                double a = GetNumberFromUser();

                Console.WriteLine("Введите второе число:");
                double b = GetNumberFromUser();

                double result = selectedOperation.Execute(a, b);
                Console.WriteLine($"Результат: {result}");
            }
            catch (Exception ex)
            {
                HandleError(ex);
            }

            Console.WriteLine("\nНажмите любую клавишу для продолжения или введите 'exit' для выхода.");
            if (Console.ReadLine().ToLower() == "exit") break;
        }
    }

    private static void ShowOperations()
    {
        Console.WriteLine("Доступные операции:");
        for (int i = 0; i < operations.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {operations[i].Name}");
        }
        Console.WriteLine("Введите 'exit' для выхода.");
    }

    private static double GetNumberFromUser()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out double result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число:");
            }
        }
    }

    private static void HandleError(Exception ex)
    {
        Console.WriteLine($"Ошибка: {ex.Message}");
        LogError(ex);
    }

    private static void LogError(Exception ex)
    {
        string errorMessage = $"{DateTime.Now}: {ex.GetType()} - {ex.Message}\n{ex.StackTrace}\n";
        File.AppendAllText("errors.log", errorMessage);
    }

    public static void AddCustomOperation(string operationName, Func<double, double, double> operationFunc)
    {
        var operation = new CustomOperation(operationName, operationFunc);
        operations.Add(operation);
        Console.WriteLine($"Операция {operationName} добавлена.");
    }

    private class CustomOperation : ICalculatorOperation
    {
        private readonly Func<double, double, double> _operationFunc;
        public string Name { get; }

        public CustomOperation(string name, Func<double, double, double> operationFunc)
        {
            Name = name;
            _operationFunc = operationFunc;
        }

        public double Execute(double a, double b) => _operationFunc(a, b);
    }
}
