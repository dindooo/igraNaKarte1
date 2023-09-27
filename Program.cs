using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace igraNaKarte1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int karte = 0;
            int zbrojkarata = 0;
            while (zbrojkarata < 31)
                {
                    Console.WriteLine("Unesite broj karata");
                try
                {
                    karte = Convert.ToInt32(Console.ReadLine());
                }
                catch(Exception greška)
                {
                    Console.WriteLine("Pogrešan unos, ponovite.");
                    Console.WriteLine(greška.Message);
                }
                if (karte >= 1 && karte <= 13)
                {
                    zbrojkarata += karte;
                }
                    if(karte<1 || karte > 13)
                {
                    Console.WriteLine("Unijeli ste pogrešan broj, nije u rasponu od 1 do 13.");
                    karte = 0;
                }
                        
                    if (zbrojkarata == 31)
                    {
                        Console.WriteLine("Pobijedili ste!");
                    }
                    else if (zbrojkarata>31)
                    {
                        Console.WriteLine("Izgubili ste. :)");
                    
                    }

                }
            Console.ReadKey();

        }
    }
}
