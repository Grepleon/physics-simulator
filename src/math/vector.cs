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

    public static Vector operator-(const Vector& v){
        return Vector(x - v.x, y - v.y, z - v.z);
    }
    public static Vector operator-(){
        return Vector() - *this;
    }
    public static Vector operator+(const Vector& v){
        return *this - (-v);
    }
}