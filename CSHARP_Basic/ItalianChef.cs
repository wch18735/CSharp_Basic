using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP_Basic
{
    class ItalianChef: Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("Chef makes pasta");
        }

        public override void MakeSpecialDish()
        {
            Console.WriteLine("Chef makes special chicken parm");
        }
    }
}
