using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp66
{
    class bil
    {
        public string märke;
        public string modell;
        public string färg;
        public int mil;
        public int årsmodell;

        public void mymetod()
        {
            bil bil = new bil();

            Console.WriteLine("Märke?");
            bil.märke = Console.ReadLine();
            Console.WriteLine("modell?");
            bil.modell = Console.ReadLine();
            Console.WriteLine("färg?");
            bil.färg = Console.ReadLine();
            Console.WriteLine("hur många mil har den kört?");
            bil.mil = int.Parse(Console.ReadLine());
            Console.WriteLine("årsmodell?");
            bil.årsmodell = int.Parse(Console.ReadLine());

            Console.WriteLine("Du har en " + bil.märke + " " + bil.modell + " " + bil.årsmodell + " din bil är " + bil.färg + " och har kört " + bil.mil + " mil");
        }



    }
}
