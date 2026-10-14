using System;
using PhysicsSimulator.Maths;

class Program
{
    static void Main()
    {
        Vector v1 = new Vector(1, 1, 2);
        Vector v2 = new Vector(1, 2, 1);
        Console.WriteLine((v1 + v2).Length());
    }
}