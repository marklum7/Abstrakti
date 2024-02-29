using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    abstract class Kerych
    {
        public abstract void katka();
    }

    class Vitun : Kerych
    {
        public override void katka()
        {
            Console.WriteLine("52NGG");
        }
    }
    class Eexie : Kerych
    {
        public override void katka()
        {
            Console.WriteLine("58ЕК");
        }
    }
    abstract class Sazuka : Kerych
    {
        public abstract override void katka();
    }
}
