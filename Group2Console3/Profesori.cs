using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2Console3
{
    internal class Profesori:Personi
    {
        public Profesori(string emri, string mbiemri):base(emri, mbiemri)
        {

        }


        public override void SayHello()
        {
            Console.WriteLine($"Hello professor {Emri} {Mbiemri}");
        }

    }
}
