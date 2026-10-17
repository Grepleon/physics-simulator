using System;
using PhysicsSimulator.Maths;

class Program
{
    static void Main()
    {
        Vector v1 = new Vector(1, 1, 2);
        Vector v2 = new Vector(1, 2, 1);
        Console.WriteLine(v1.Length());
        Console.WriteLine(v2.Length());
        Console.WriteLine((v1 + v2).Length());
        Console.WriteLine((v1 - v2).Length());
        Console.WriteLine((v1 * 2).Length());
        Console.WriteLine((v1 / 3).Length());
        Console.WriteLine((v2 / 5).Length());
        Console.WriteLine((v1 * 5).Length());

    }
}