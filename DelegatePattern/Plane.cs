using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatePattern
{
    public class Plane: IPlane
    {
        public void Fly()
        {
            Console.WriteLine("Plane is flying");
        }
    }
}
