/*
Создать игру "Кто хочет стать миллионером"
Необходимый функционал 
1 Минимум 10 вопросов 
2 несгораемая сумма 
3 Подсказки (50 / 50, помощь зала, помощь друга  )
4 Право на ошибку 
5 Забрать деньги 
*/

class Program
{
    public static int UserBalanceCount(int a, int[] money)
    {
        int returned = 0;
        for (int i = 0; i < money.Length; i++)
        {
            if (i <= a)
            {
                returned += money[i];
            }
            else
            {
                break;
            }

        }
        return returned;
    }
    public static string GameGuestions(int a)
    {
        string[] gussions =
        {
            "1. Столица Франции — это:",
            "2. Какой элемент обозначается символом \"O\" таблице Менделеева?",
            "3. Кто написал роман \"Война и мир\"?",
            "4. Сколько планет в Солнечной системе?",
            "5. В каком году началась Вторая мировая война?",
            "6. Как называется крупнейший океан на Земле?",
            "7. Сколько граней у куба?",
            "8. Какой газ необходим человеку для дыхания?",
            "9. Какой город является столицей Японии?",
            "10. Кто нарисовал \"Мону Лизу\"?",

        };
        return gussions[a];
    }
    public static string GameAnswers(in int a, in int b)
    {
        string[,] answers =
{
            {"A) Лион","B) Марсель","C) Париж","D) Ницца" }, // 1 
            {"A) Золото","B) Водород","C) Кислород","D) Углерод"}, // 2 
            {"A) Достоевский","B) Чехов","C) Лермонтов","D) Толстой"}, // 3 
            {"A) 7","B) 8","C) 9","D) 10"}, // 4 
            {"A) 1914","B) 1939","C) 1945","D) 1950"}, // 5 
            {"A) Атлантический", "B) Тихий", "C) Индийский","D) Северный Ледовитый"}, // 6 
            {"A) 4","B) 6","C) 8","D) 12"}, // 7 
            {"A) Азот","B) Углекислый газ","C) Гелий","D) Кислород"}, // 8
            {"A) Киото","B) Хиросима","C) Токио","D) Осака"}, // 9 
            {"A) Пабло Пикассо","B) Винсент ван Гог","C) Леонардо да Винчи","D) Микеланджело"}

        };


        return answers[a, b];
    }
    public static void HelpingUsers(string[] correct, int numIteration, ref bool fifyFifty, ref bool helpOfPeople, ref bool callFriends)
    {

        string[] arrayOfLetters = { "A", "B", "C", "D" };

        
        Random random = new Random();

        if (fifyFifty || helpOfPeople || callFriends)
        {
            System.Console.WriteLine("Выберите действие:\n");
        }
        
        int numRandom = random.Next(0, 3);
        // 50/50
        if (fifyFifty)
        {
            System.Console.WriteLine("1 - 50/50");
        }
        if (helpOfPeople)
        {
            System.Console.WriteLine("2 - Помощь зала");
        }
        if (callFriends)
        {
            System.Console.WriteLine("3 - Звонок другу");
        }

        string userInput = Console.ReadLine().ToUpper();
        if (fifyFifty == true && userInput == "1")
        {

            fifyFifty = false;



            if (arrayOfLetters[numRandom] != correct[numIteration])
            {
                System.Console.WriteLine($"Первый вариант: {arrayOfLetters[numRandom]} ");
                System.Console.WriteLine($"Второй вариант: {correct[numIteration]}");
            }
            else
            {
                System.Console.WriteLine($"Первый вариант: {arrayOfLetters[numRandom - 1]} ");
                System.Console.WriteLine($"Второй вариант: {correct[numIteration]}");
            }

        }
        // Помощь зала
        if (helpOfPeople == true && userInput == "2")
        {
            helpOfPeople = false;

            for (int i = 0; i < arrayOfLetters.Length; i++)
            {
                numRandom = random.Next(0, 50);
                int correctNumber = random.Next(60, 100);

                if (arrayOfLetters[i] == correct[numIteration])
                {
                    System.Console.WriteLine($"{correctNumber}% Людей думают что ответ: {arrayOfLetters[i]}");
                }
                else
                {
                    System.Console.WriteLine($"{numRandom}% Людей думают что ответ: {arrayOfLetters[i]}");
                }

            }
        }
        // Звонок другу 
        if (callFriends == true && userInput == "3")
        {
            callFriends = false;

            numRandom = random.Next(60, 100);
            if (numRandom > 80)
            {
                System.Console.WriteLine($"Ваш друг думает что ответ {correct[numIteration]}");
            }
            else
            {
                System.Console.WriteLine("Ваш друг не знает точного ответа");
            }
        }
    }
    



    public static void Main()
    {
        string[] correctAnswers = { "C", "C", "D", "B", "B", "B", "B", "D", "C", "C" };
        int[] bank = { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 };

        bool fifyFifty = true;
        bool helpOfPeople = true;
        bool callFriends = true;
        string userInput;
        int failsCount = 0;
        int userBalance;
        int countGuestion = 0;


        for (int i = 0; i < 10; i++) // вопросы 
        {

            System.Console.WriteLine($"Вопрос на {bank[i]} Манат \n");
            System.Console.WriteLine(GameGuestions(i));

            for (int k = 0; k < 4; k++) // ответы
            {
                System.Console.WriteLine(GameAnswers(i, k));

            }
            System.Console.WriteLine();
            System.Console.WriteLine("H - Подсказки, Q - забрать деньги");
            userInput = Console.ReadLine().ToUpper();

            if (userInput == "Q")
            {
                userBalance = UserBalanceCount(i, bank);
                System.Console.WriteLine($"Поздравляем ваш выйгрыш состовляет: {userBalance}");
                break;
            }
            if (userInput == "H")
            {
                HelpingUsers(correctAnswers, i, ref fifyFifty, ref helpOfPeople, ref callFriends);
                userInput = Console.ReadLine().ToUpper();


            }

            if (userInput != "A" && userInput != "B" && userInput != "C" && userInput != "D")
            {
                Console.Clear();
                System.Console.WriteLine("Вы вели не верное значение пожалуйста повторите");
                i--;
                continue;
            }

            if (userInput == correctAnswers[i])
            {
                Console.Clear();
                userBalance = UserBalanceCount(i, bank);
                Console.WriteLine($"Отлично\nВаш баланс: {userBalance} Манат.");
                countGuestion++;
                continue;
            }
            else
            {
                Console.Clear();
                System.Console.WriteLine("Ответ не верный\n");
                failsCount++;
            }

            if (failsCount == 2)
            {
                if (countGuestion == 4 || countGuestion == 7)
                {
                    System.Console.WriteLine($"Игра окончена ваш выйгрышь: {bank[i]}");
                    break;
                }
                else
                {
                    System.Console.WriteLine("Игра окончена вы проиграли");
                    break;
                }
            }

        }
    }
}



