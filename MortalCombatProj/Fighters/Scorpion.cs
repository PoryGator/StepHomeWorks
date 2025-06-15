

namespace MortalCombatProj.Fighters.Indicators
{
    public class Scorpion : Indicators
    {
        public Scorpion() : base("Scorpion", 37, 5, 5) { }
        public override void SkinFightres()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(@" 
 s__||__
 / x  x \\
|   ><   |
 \\_--_//
  ||  ||
 / |||| \\
/_/ \\_\\");
        Console.ResetColor();}
        
        public override void Xray()
        {
            System.Console.Write("========>>>");
        }
    }
}