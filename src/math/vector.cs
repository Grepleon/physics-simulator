using System;
namespace PhysicsSimulator.Maths;

class Vector{
    private double x, y, z;
    public Vector(){
        x = 0;
        y = 0;
        z = 0;
    }
    public Vector(double dx, double dy, double dz){
        x = dx;
        y = dy;
        z = dz;
    }

    public static Vector operator -(Vector a, Vector b){
        return new Vector(a.x - b.x, a.y - b.y, a.z - b.z);
    }
    public static Vector operator -(Vector a){
        return new Vector() - a;
    }
    public static Vector operator +(Vector a, Vector b){
        return a - (-b);
    }
    public static Vector operator *(Vector a, double k){
        return new Vector(a.x * k, a.y * k, a.z * k);
    }
    public static Vector operator *(double k, Vector a){
        return a * k;
    }
    public static Vector operator /(Vector a, double k){
        return a * (1 / k);
    }

    public double Length(){
        return (Math.Sqrt(x * x + y * y + z * z));
    }
}