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

    public static Vector operator-(const Vector& a, const Vector& b){
        return Vector(a.x - b.x, a.y - b.y, a.z - b.z);
    }
    public static Vector operator-(const Vector& a){
        return Vector() - a;
    }
    public static Vector operator+(const Vector& a, const Vector& b){
        return a - (-b);
    }
}