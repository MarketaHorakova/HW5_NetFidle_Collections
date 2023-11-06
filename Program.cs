using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_NetFidle_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Vypiš aktuální datum a čas, nemusíš řešit, v kterém je to časovém pásmu.
            DateTime ted = DateTime.Now;
            Console.WriteLine(ted);

            // 2. Vytvoř proměnnou typu DateTime a ulož do ní svoje datum narození. Potom vypiš, kolik dnů od té doby uteklo.	
            DateTime datumNarozeni = new DateTime(1990, 1, 5, 8, 30, 0);
            TimeSpan rozdilCasu = ted - datumNarozeni;
            Console.WriteLine(rozdilCasu);

            // 3. Vytvoř list stringů a vlož do něj 5 různých hodnot.
            List<string> seznam = new List<string> { "prvni", "druha", "treti", "ctvrta", "pata" };
            // 4. Smaž z tohoto listu libovolnou hodnotu.
            seznam.Remove("treti");
            // 5. Zjisti, jestli tento list obsahuje nějakou hodnotu pomocí list metody Contains ... zkus na internetu zjistit, jak ji použít.
            bool seznamObsahujeHodnotu = seznam.Contains("treti");
            Console.WriteLine(seznamObsahujeHodnotu);
            // 6. Vypiš do konzole, kolik je v tom listu prvků a připoj k tomu všechny ty hodnoty (např: "2: modra, zelena").
            Console.Write($"{seznam.Count}:\t");
            foreach (string s in seznam)
            {
                Console.Write($"{s}, ");
            }
            // 7. Vytvoř slovník, kde klíčem bude položka nákupu (string) a hodnotou cena té položky, a vlož nějaké hodnoty (např: <"chleba", 20>).
            Dictionary<string, int> kosik = new Dictionary<string, int>() { 
                { "chleba", 80 },
                {"maslo", 40 },
                {"jogurt", 25 },
                {"hovezi mlete", 150},
                {"racatova passata", 30},
                {"chedar", 80},
                {"mouka", 35} 
            };
            // 8. Zjisti, jestli slovník obsazhuje nějakou konkrétní potravinu a pokud ano, vypiš její cenu, pokud ne, vypiš, že není.
            Console.WriteLine();
            Console.WriteLine("Na jakou polozku se ptame?");
            string inputPolozkaOdUzivatele = Console.ReadLine();
            if (kosik.TryGetValue(inputPolozkaOdUzivatele, out int value))
            {
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine("potravina neni v kosiku");
            }
            // 9. Řekněme, že už jsi do slovníku přidala např. chleba a zjistila, že máš v nákupní tašce ještě jeden -> uprav hodnotu k tomu klíči tak, aby obsahovala hromadnou cenu za všechny stejné položky.
            string chciPridat = "chleba";

            if (kosik.ContainsKey(chciPridat)) 
            {

                kosik.TryGetValue(chciPridat, out int originValue);
                kosik[chciPridat] = originValue*2;
            }

            foreach (KeyValuePair<string,int> s in kosik) 
            { 
                Console.WriteLine($"{s.Key} : {s.Value}");
            }


            Console.ReadLine();
        }
    }
}
