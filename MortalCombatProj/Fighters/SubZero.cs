
namespace MortalCombatProj.Fighters.Indicators
{
    public class SubZero : Indicators
    {
        public SubZero() : base("SubZero", 40, 3, 5) {}


        public override void SkinFightres()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(@" 
  z__||__
 / o  o \\
|   __   |
 \\_==_//
  ||  ||
 / |||| \\
/_/  \\_\\");
            Console.ResetColor();
        }

        public override void Xray()
        {
            System.Console.Write("@@@@@@@@@@@@@@");
        }
    }
}