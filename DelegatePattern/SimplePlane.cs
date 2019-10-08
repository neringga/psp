using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatePattern
{
    public class SimplePlane: IPlane
    {
        private IPlane _plane = new Plane();

        public void Fly()
        {
            _plane.Fly();
        }
    }
}
