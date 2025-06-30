
using MortalCombatProj.Fighters;
using MortalCombatProj.Fighters.Indicators;

class Program
{
  public static void Main()
  {
    VisualClass visualClass = new VisualClass();
    Ring ring = new Ring();


    visualClass.MkLogo();
    visualClass.PrintFightres();

    Indicators player1 = ChoiceofFighter.ChoiceFighter();
    Indicators player2 = ChoiceofFighter.ChoiceFighter();
    ring.RingOfFighters(player1, player2);
  
    

  }
}