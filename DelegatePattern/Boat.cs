using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatePattern
{
    public class Boat: IWheel, IBrake, IHorn
    {
        private IWheel _wheel = new Wheel();
        private IBrake _brake = new Brake();
        private IHorn _horn = new Horn();

        public void Swim()
        {
            Console.WriteLine("Boat is swimming");
        }

        public void Turn(string side)
        {
            _wheel.Turn(side);
        }

        public void Stop()
        {
            _brake.Stop();
        }

        public void SlowDown()
        {
            _brake.SlowDown();
        }

        public void Beep()
        {
            _horn.Beep();
        }
    }
}
