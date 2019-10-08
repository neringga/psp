using System;

namespace DelegatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var boat = new Boat();
            boat.Swim();
            boat.Beep();

            var plane = new CoolPlane();
            plane.Fly();
            plane.Turn("left");

            var simplePlane = new SimplePlane();
            simplePlane.Fly();

            var car = new Car();
            car.Drive();
            car.Stop();

            Console.ReadKey();
        }
    }
}
