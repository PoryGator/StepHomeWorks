public class Addition : ICalculatorOperation
{
    public double Execute(double a, double b) => a + b;
    public string Name => "Сложение";
}

public class Subtraction : ICalculatorOperation
{
    public double Execute(double a, double b) => a - b;
    public string Name => "Вычитание";
}

public class Multiplication : ICalculatorOperation
{
    public double Execute(double a, double b) => a * b;
    public string Name => "Умножение";
}

public class Division : ICalculatorOperation
{
    public double Execute(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Нельзя делить на ноль.");
        }
        return a / b;
    }
    public string Name => "Деление";
}