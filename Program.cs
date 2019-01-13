using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ttiMegoldasCS
{
    class Program
    {
        static void Main(string[] args)
        {
            int tomegKG;
            int magassagCM;
            double magassagM;
            double bmi;
            string nev;
            bool ujra = true;

            while (ujra == true)
            {
                try
                {
                    do
                    {
                        Console.Clear();
                        Console.Write("Adja meg a nevét: ");
                        nev = Console.ReadLine();
                        Console.Write("Adja meg a tömegét kg-ban, egész számra kerekítve: ");
                        tomegKG = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Adja meg a magasságát cm-ben, egész számra kerekítve: ");
                        magassagCM = Convert.ToInt32(Console.ReadLine());
                    }
                    while (0 > magassagCM || magassagCM > 300 || 0 > tomegKG || tomegKG > 600);

                    
                    magassagM = Convert.ToDouble(magassagCM) / 100;
                    bmi = Convert.ToDouble(tomegKG) / Math.Pow(magassagM, 2);
                    

                    if (bmi < 16)
                    {
                        Console.WriteLine(nev + " testtömegindexe " + Math.Round(bmi, 2) + ": kórosan sovány");
                    }
                    else if (16 <= bmi && bmi < 18.5)
                    {
                        Console.WriteLine(nev + " testtömegindexe " + Math.Round(bmi, 2) + ": sovány");
                    }
                    else if (18.5 <= bmi && bmi < 25)
                    {
                        Console.WriteLine(nev + " testtömegindexe " + Math.Round(bmi, 2) + ": normális");
                    }
                    else if (25 <= bmi && bmi < 40)
                    {
                        Console.WriteLine(nev + " testtömegindexe " + Math.Round(bmi, 2) + ": túlsúlyos/elhízott");
                    }
                    else if (bmi >= 40)
                    {
                        Console.WriteLine(nev + " testtömegindexe " + Math.Round(bmi, 2) + ": kórosan elhízott");
                    }
                }
                catch (Exception hiba)
                {
                    Console.WriteLine("Hiba: " + hiba.Message);
                }
                finally
                {
                    Console.Write("Szeretne új adatokkal számolni? ");
                    ujra = Console.ReadLine().Contains("i");
                }
            }
        }
    }
}
