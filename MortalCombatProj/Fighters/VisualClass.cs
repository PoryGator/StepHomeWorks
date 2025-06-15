

using MortalCombatProj.Fighters.Indicators;

namespace MortalCombatProj.Fighters
{
    public class VisualClass
    {

        SubZero subZero = new SubZero();
        Scorpion scorpion = new Scorpion();
        Kitana kitana = new Kitana();
        public void MkLogo()
        {
            string[] snowflake = new string[]
{
            @"                       _..gggggppppp.._                       ",
            @"                  _.gd$$$$$$$$$$$$$$$$$$bp._                  ",
            @"               .g$$$$$$P^^""j$$b""""^^T$$$$$$p.               ",
            @"            .g$$$P^T$$b    d$P T;       ""^^T$$$p.            ",
            @"          .d$$P^""  :$; `  :$;                ""^T$$b.          ",
            @"        .d$$P'      T$b.   T$b                  `T$$b.        ",
            @"       d$$P'      .gg$$$$bpd$$$p.d$bpp.           `T$$b       ",
            @"      d$$P      .d$$$$$$$$$$$$$$$$$$$$bp.           T$$b      ",
            @"     d$$P      d$$$$$$$$$$$$$$$$$$$$$$$$$b.          T$$b     ",
            @"    d$$P      d$$$$$$$$$$$$$$$$$$P^^T$$$$P            T$$b    ",
            @"   d$$P    '-'T$$$$$$$$$$$$$$$$$$bggpd$$$$b.           T$$b   ",
            @"  :$$$      .d$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$p._.g.     $$$;  ",
            @"  $$$;     d$$$$$$$$$$$$$$$$$$$$$$$P^""^T$$$$P^^T$$$;    :$$$  ",
            @" :$$$     :$$$$$$$$$$$$$$:$$$$$$$$$_    ""^T$bpd$$$$,     $$$; ",
            @" $$$;     :$$$$$$$$$$$$$$bT$$$$$P^^T$p.    `T$$$$$$;     :$$$ ",
            @":$$$      :$$$$$$$$$$$$$$P `^^^'    ""^T$p.    lb`TP       $$$;",
            @":$$$      $$$$$$$$$$$$$$$              `T$$p._;$b         $$$;",
            @"$$$;      $$$$$$$$$$$$$$;                `T$$$$:Tb        :$$$",
            @"$$$;      $$$$$$$$$$$$$$$                        Tb    _  :$$$",
            @":$$$     d$$$$$$$$$$$$$$$.                        $b.__Tb $$$;",
            @":$$$  .g$$$$$$$$$$$$$$$$$$$p...______...gp._      :$`^^^' $$$;",
            @" $$$;  `^^'T$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$p.    Tb._, :$$$ ",
            @" :$$$       T$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$b.   ""^""  $$$; ",
            @"  $$$;       `$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$b      :$$$  ",
            @"  :$$$        $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$;     $$$;  ",
            @"   T$$b    _  :$$`$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$;   d$$P   ",
            @"    T$$b   T$g$$; :$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$  d$$P    ",
            @"     T$$b   `^^'  :$$ ""^T$$$$$$$$$$$$$$$$$$$$$$$$$$$ d$$P     ",
            @"      T$$b        $P     T$$$$$$$$$$$$$$$$$$$$$$$$$;d$$P      ",
            @"       T$$b.      '       $$$$$$$$$$$$$$$$$$$$$$$$$$$$P       ",
            @"        `T$$$p.         d$$$$$$$$$$$$$$$$$$$$$$$$$$P'        ",
            @"          `T$$$$p..__..g$$$$$$$$$$$$$$$$$$$$$$$$$$P'          ",
            @"            ""^$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$^""            ",
            @"               ""^T$$$$$$$$$$$$$$$$$$$$$$$$$$P^""               ",
            @"                   """"^^^T$$$$$$$$$$P^^^""""                   " };



            Console.ForegroundColor = ConsoleColor.Red;

            foreach (string line in snowflake)
            {
                Console.WriteLine(line);
                Thread.Sleep(80);
            }

            Console.ResetColor();

        }

        public void PrintFightres()
        {
            subZero.SkinFightres();
            System.Console.WriteLine();
            scorpion.SkinFightres();
            System.Console.WriteLine();
            kitana.SkinFightres();
        }

        public void ShowHp(int hp, string name, int left = 0, int top = -1)
        {
            if (top >= 0)
                Console.SetCursorPosition(left, top);
            Console.WriteLine(name);

            if (top >= 0)
                Console.SetCursorPosition(left, Console.CursorTop);
            for (int i = 0; i < hp; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            
        }
        



    }
}