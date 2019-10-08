using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatePattern
{
    public class CoolPlane: IPlane, IWheel, IBrake
    {
        private IWheel _wheel = new Wheel();
        private IBrake _brake = new Brake();
        private IPlane _plane = new Plane();

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

        public void Fly()
        {
            _plane.Fly();
        }
    }
}
