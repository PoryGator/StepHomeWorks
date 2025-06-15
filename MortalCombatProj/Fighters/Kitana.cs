

namespace MortalCombatProj.Fighters.Indicators
{
    public class Kitana : Indicators
    {
        public Kitana() : base("Kitana", 35, 6, 8) { }// its woman 
        public override void SkinFightres()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(@" 
  k__||__
 / .  . \\
|   ∆    |
 \\_~~_//
  ||  ||
 / |||| \\
(_/  \\_)");
            Console.ResetColor();
}

        public override void Xray()
        {
            System.Console.Write("{]{}{][]}][]}}");
        }
        
    }
}