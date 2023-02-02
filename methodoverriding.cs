using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace methodoverriding
{
    class demo
    {
        public virtual void show()
        {
            Console.WriteLine("Base class function");
        }
    }
    class demo1:demo
    {
        public override void show()
        {
            base.show();
            Console.WriteLine("derived class function");
        }

    }
    class program
    {
        static void Main(string[] args)
        {
            demo1 d1 = new demo1();
            d1.show();
            Console.ReadLine();
        }
    }
}
