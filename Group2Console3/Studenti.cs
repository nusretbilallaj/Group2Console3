using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2Console3
{
    internal class Studenti:Personi
    {
        public Studenti(string emri,string mbiemri,int mosha):base(emri,mbiemri)
        {
            Mosha=mosha;
        }
        public int Mosha { get; set; }

        public override void SayHello()
        {
            Console.WriteLine($"Hello student {Emri} {Mbiemri}");
        }
    }
}
