using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negyszogek
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Szia user!");
			
            negyszog negyszog1 = new negyszog(1, 2, 3, 4);
            Console.WriteLine(negyszog1);
            Console.WriteLine(negyszog1.Kerulet);

            Teglalap teglalap1 = new Teglalap(1, 5);
            Console.WriteLine(teglalap1);
            Console.WriteLine(teglalap1.Kerulet);

            Negyzet negyzet1 = new Negyzet(8);
            Console.WriteLine(negyzet1);
            Console.WriteLine(negyzet1.Kerulet);

            List<negyszog> negyszogek = new List<negyszog>();
            negyszogek.Add(negyszog1);
            negyszogek.Add(teglalap1);
            negyszogek.Add(negyzet1);

            int hossz = 0;
            foreach (var elem in negyszogek)
            {
                hossz += elem.Kerulet;
            }

            Console.WriteLine("Összesen {0} fonalra van szükség.",hossz);

            Console.ReadKey();
        }
    }
}
