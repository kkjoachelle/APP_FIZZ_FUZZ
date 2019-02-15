using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_FIZZ_FUZZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int Nbrefizz = 0;
            int Nbrefuzz = 0;
            int Nbrfizzfuzz = 0;
            
            StringBuilder stg3 = new StringBuilder();
            StringBuilder stg5 = new StringBuilder();
            StringBuilder stg35 = new StringBuilder();

            ////les listes génériques
            List<int> TabARR = new List<int>();
            //------------
            List<String> TabStr = new List<String>();
           /* ArrayList TabStr1 = new ArrayList();
            TabStr1.Add(1);
            TabStr1.Add("koffi kouadip");*/

            TabStr.Add(("KOFFI"));
            TabStr.Add(("KOUADIO JOACHIM"));
            TabStr.Add(("EST A SAN PEDRO"));
            TabStr.Add(("VILLE SITUEE EN CI"));
            //
            //
            for (int i = 3; i <= 100; i++)
            {

                if (i % 3 == 0)
                {
                    Nbrefizz++;
                    stg3.Append(" "+i);
                }

                if (i % 5 == 0)
                {
                    Nbrefuzz++;
                    stg5.Append(" "+i);
                }

                if ((i % 5 == 0) && (i % 3 == 0))
                {
                    Nbrfizzfuzz++;
                    stg35.Append(" " + i);
                }

                //-----------
                TabARR.Add(i);
               
            }
            Console.WriteLine("Les multiple de 3 sont: "+ Nbrefizz);
            Console.WriteLine("  " + stg3);
            Console.WriteLine("Les multiple de 5 sont: "+ Nbrefuzz);
            Console.WriteLine("  " + stg5);
            Console.WriteLine("Les multiple de 3 et de 5 sont: "+ Nbrfizzfuzz);
            Console.WriteLine("  " + stg35);
           
            //------------
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Utilisation des listes génériques");
            foreach (int item in TabARR)
            {
                Console.Write(" "+item);
            }

            //vérifiction des index
            Console.WriteLine("  ");
            Console.WriteLine("//--------//-----------//------//-");
            foreach (int item in TabARR)
            {
                int ind = TabARR.IndexOf(item);
                Console.Write(" " + ind);
            }
            Console.WriteLine("  ");

            //------------
            Console.WriteLine("======================");
            foreach (var item in TabStr)
            {
                Console.Write(" "+ item);
            }

            Console.ReadKey();
        }
    }
}
