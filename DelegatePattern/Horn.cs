using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatePattern
{
    public class Horn: IHorn
    {
        public void Beep()
        {
            Console.WriteLine("Beeeep");
        }
    }
}
