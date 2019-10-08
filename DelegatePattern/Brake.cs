using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatePattern
{
    public class Brake: IBrake
    {
        public void Stop()
        {
            Console.WriteLine("Stopped");
        }

        public void SlowDown()
        {
            Console.WriteLine("Slow downed");
        }
    }
}
