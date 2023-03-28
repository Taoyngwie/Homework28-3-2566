public class Vector2
{
    //  Abscissa.
    public double x;

    //  Ordinate.
    public double y;

    public Vector2(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    //  Compute this vector magnitude.
    public double Magnitude()
    {
        return Math.Sqrt((this.x * this.x) + (this.y * this.y));
    }

    public static Vector2 operator +(Vector2 u)
    {
        return u;
    }

    public static Vector2 operator -(Vector2 u)
    {
        return new Vector2(-u.x, -u.y);
    }

    public static Vector2 operator +(Vector2 u, Vector2 v)
    {
        return new Vector2(u.x + v.x, u.y + v.y);
    }

    public static Vector2 operator -(Vector2 u, Vector2 v)
    {
        return u + (-v);
    }

    //  Compute a dot product between two given vector.
    public static double operator *(Vector2 u, Vector2 v)
    {
        return (u.x * v.x) + (u.y * v.y);
    }

    //  Compute a product between given scala and vector.
    public static double operator *(Vector2 u, double k)
    {
        return (u.x * k) + (u.y * k);
    }

    //  Compute a product between given scala and vector.
    public static double operator *(double k, Vector2 u)
    {
        return u * k;
    }

    public static Vector2 Copy(Vector2 u)
    {
        return new Vector2(u.x, u.y);
    }

    public override string ToString()
    {
        return string.Format("Vector2(x: {0}, y: {1})", this.x, this.y);
    }
    public static bool IsPointInsidePolygon(List<Vector2> vertices, Vector2 point)
    {
        int numberOfVertices = vertices.Count;
        bool isInside = false;
        int j = numberOfVertices - 1;

        for (int i = 0; i < numberOfVertices; i++)
        {
            if (vertices[i].y < point.y && vertices[j].y >= point.y || vertices[j].y < point.y && vertices[i].y >= point.y)
            {
                if (vertices[i].x + (point.y - vertices[i].y) / (vertices[j].y - vertices[i].y) * (vertices[j].x - vertices[i].x) < point.x)
                {
                    isInside = !isInside;
                }
            }
            j = i;
        }

        return isInside;
    }
}