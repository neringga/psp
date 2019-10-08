using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatePattern
{
    class Wheel: IWheel
    {
        public void Turn(string side)
        {
            Console.WriteLine($"Wheel turned to {side}");
        }
    }
}
