using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMethodUpLow
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Personer = new List<string>();

            string PersonID;
            string efternavn = "";
            string fornavn = "";
            do
            {
                Console.WriteLine("indtast Person id");
                PersonID = Console.ReadLine().Trim();
                if (PersonID != "")
                {
                    string[] navn = PersonID.Split();
                    //tager lenght af array og minus med 1 derefter sætter værdi af array på "" nr til efternavn.
                    efternavn = StortOgSmaat(navn[navn.Length - 1]);//0 1 2 3
                    fornavn = "";//værdi bliver intet.

                    for (int i = 0; i < navn.Length - 1; i++)
                    {
                        //udskriver resten af array fra array bare ikke det sidste nr.
                        fornavn += StortOgSmaat(navn[i]) + " ";//sætter ind værdi af navn[i]
                    }
                    //sætter det hele sammen så udskriften bliver skrevet rigtigt.
                    string all = efternavn + ", " + fornavn;
                    Personer.Add(all);
                }
                /*en anden måde at lave den på
                 Console.WriteLine("indtast fornavn");
                 navn = Console.ReadLine().Trim();
                 Console.WriteLine("indtast efternavn");
                 efternavn = Console.ReadLine().Trim();
                 navn = StortOgSmaat(navn);
                 efternavn = StortOgSmaat(efternavn);
                 string all = efternavn + ", " + navn;
                 Personer.Add(all);*/

            } while (/*navn != "" && efternavn != ""*/
            /*&&*/ PersonID != "");

            Personer.Sort();
            Console.Clear();
            foreach (string prime in Personer)
            {
                Console.WriteLine(prime);
            }

            string StortOgSmaat(string inavn)
            {
                if (inavn.Length != 0)
                {
                    return inavn.Substring(0, 1).ToUpper() + //her laver vi stort på det første bogstav
                        inavn.Substring(1).ToLower();//her gøre vi resten af bogstaverne småt.                
                }
                else
                    return "";
            }

            //string AliasGen(string alias)
            //{
            //    Dictionary <string, int> dictionary = new Dictionary<string, int>();
            //    for (int i = 0; i < length; i++)
            //    {

            //    }

            //    //alias = fornavn.Substring(0, 2).ToString() +
            //    //   efternavn.Substring(0, 2).ToString();
            //return "";
            //}

            Console.ReadKey();
        }
    }
}
