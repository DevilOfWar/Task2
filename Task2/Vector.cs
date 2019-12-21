using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Vector
    {
        public double X
        {
            get; private set;
        }
        public double Y
        {
            get; private set;
        }
        public double Z
        {
            get; private set;
        }
        public Vector (double X, double Y, double Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }
        public static Vector operator +(Vector first, Vector second)
        {
            Vector result = new Vector(0, 0, 0);
            result.X += first.X;
            result.Y += first.Y;
            result.Z += first.Z;
            result.X += second.X;
            result.Y += second.Y;
            result.Z += second.Z;
            return result;
        }
        public static Vector operator -(Vector first, Vector second)
        {
            Vector result = new Vector(0, 0, 0);
            result.X += first.X;
            result.Y += first.Y;
            result.Z += first.Z;
            result.X -= second.X;
            result.Y -= second.Y;
            result.Z -= second.Z;
            return result;
        }
        public static Vector operator *(Vector vector, int number)
        {
            Vector result = new Vector(0, 0, 0);
            result.X += vector.X * number;
            result.Y += vector.Y * number;
            result.Z += vector.Z * number;
            return result;
        }
        public static Vector operator *(Vector first, Vector second)
        {
            Vector result = new Vector(0, 0, 0);
            result.X = first.Y * second.Z - first.Z * second.Y;
            result.Y = first.Z * second.X - first.X * second.Z;
            result.Z = first.X * second.Y - first.Y * second.X;
            return result;
        }
        public static double operator ^(Vector first, Vector second)
        {
            return first.X * second.X + first.Y * second.Y + first.Z * second.Z;
        }
    }
}
