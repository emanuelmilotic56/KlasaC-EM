using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaCZad_EM
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[5];

            Console.WriteLine("Upišite 5 cijelih brojeva:");
            for (int i = 0; i < 5; i++)
            {
                string s = Console.ReadLine();
                arr[i] = Convert.ToInt32(s);
            }
            KlasaC x = new KlasaC();
            int zbroj = x.Zbroj(arr);
            Console.WriteLine(zbroj);
            double prosjek = x.Prosjek(arr);
            Console.WriteLine(prosjek);

        }
    }
}
