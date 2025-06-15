using MortalCombatProj.Fighters;
using MortalCombatProj.Fighters.Indicators;

public class Ring 
{
    private int countUser = 0;
    private int countBot = 0;
    VisualClass visualClass = new VisualClass();

    public void RingOfFighters(Indicators player1, Indicators player2)
    {
        Random random = new Random();
        int userAction;
        int botAction;

        while (player1.Hp > 0 && player2.Hp > 0)
        {
            Console.Clear();
            visualClass.ShowHp(player1.Hp, player1.Name);
            visualClass.ShowHp(player2.Hp, player2.Name, left: 50, top: 0);

            player1.SkinFightres();
            Console.SetCursorPosition(left:80, top:10);
            player2.SkinFightres();

            
            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("1. Атака");
            Console.WriteLine("2. Защита");
            Console.WriteLine("3. X-Ray");

            userAction = ChoiceofFighter.IntUserInput();
            botAction = random.Next(1, 4);
            bool player1Defending = false;
            bool player2Defending = false;
            Console.WriteLine($"\nХод игрока({player1.Name}):");
            player1.SkinFightres();
            if (userAction == 2)
            {
                player1Defending = true;
                
                System.Console.WriteLine("Защищается");
            }

            if (botAction == 2)
            {
                player2Defending = true;
                player2.SkinFightres();
                System.Console.WriteLine("Защищается");

            }
            // ---------- ход игрока ------------------------------
            if (userAction == 1) // атака
            {
                System.Console.WriteLine("Атакует");
                if (player2Defending)
                {
                    player2.Hp = player2.Hp - (player2.Defence - player1.Attack);
                }
                else
                {
                    player2.Hp = player2.Hp - player1.Attack;
                }
                countUser++;

            }
            if (userAction == 3 && countUser >= 3) // X-Ray ----------------------------------
            {

                player1.SkinFightres();
                player1.Xray();


                if (player2Defending)
                {
                    player2.Hp = player2.Hp - player1.Attack;
                }
                else
                {
                    player2.Hp = player2.Hp - player1.Attack * 2;
                }

            }

            if (player2.Hp <= 0)
                break;

            Thread.Sleep(1000);

            //-=-=-=-=-=--=-=-=-=-=-=- BOT -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=--
            Console.WriteLine($"\nХод противника ({player2.Name}):");
            player2.SkinFightres();
            if (botAction == 1)
            {
                System.Console.WriteLine("атакует");
                if (player1Defending)
                {
                    player1.Hp = player1.Hp - (player1.Defence - player2.Attack);
                }
                else
                {
                    player1.Hp = player1.Hp - player2.Attack;
                }
                countBot++;
                

            }
            // ________________+_+_+_+_+_+_++_+_ X RAY _+__+_+_+_+_+_+_
            if (botAction == 3 && countBot >= 3 )
            {

                player2.Xray();

                System.Console.WriteLine();
                if (player1Defending)
                {
                    player1.Hp = player1.Hp - player2.Attack;
                }
                else
                {
                    player1.Hp = player1.Hp - player2.Attack * 2;
                }

            }
            
            Console.WriteLine("\n-----------------------------\n");
            
        }


        if (player1.Hp > 0)
            Console.WriteLine($"\n{player1.Name} победил!");
        else
            Console.WriteLine($"\n{player2.Name} победил!");
    }
}



