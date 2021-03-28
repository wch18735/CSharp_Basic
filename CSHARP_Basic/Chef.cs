using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP_Basic
{
    class Chef
    {
        public void MakeSalad()
        {
            Console.WriteLine("Chef makes salad");
        }

        public void MakeChicken()
        {
            Console.WriteLine("Chef makes chicken");
        }

        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("Chef makes special bbq ribs");
        }
    }
}
