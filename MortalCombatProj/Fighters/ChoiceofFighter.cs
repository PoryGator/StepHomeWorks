using MortalCombatProj.Fighters.Indicators;

public class ChoiceofFighter
{
    public static Indicators ChoiceFighter()
    {
        System.Console.WriteLine("\n1 - SubZero");
        System.Console.WriteLine("2 - Scorpion");
        System.Console.WriteLine("3 - Kitana");

        while (true)
        {
            System.Console.WriteLine("Ваш выбор: ");
            string input = Console.ReadLine();


            switch (input)
            {
                case "1":
                    return new SubZero();
                case "2":
                    return new Scorpion();
                case "3":
                    return new Kitana();
                default:
                    System.Console.WriteLine("Повторите выбор");
                    break;
            }
        }
    }
    
    public static int IntUserInput()
    {
        while (true)
        {
            int input = int.Parse(Console.ReadLine());


            switch (input)
            {
                case 1:
                    return 1;
                case 2:
                    return 2;
                case 3:
                    return 3;
                default:
                    System.Console.WriteLine("Повторите выбор");
                    break;
            }
        }
    }


}