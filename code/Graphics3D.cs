using System;
using System.Collections.Generic;
using System.Text;

namespace PKG_6
{
    class Graphics3D
    {
        public static double toRad(int angle)
        {
            return (double)angle / 180 * Math.PI;
        }
        public static Matrix rotateOx(double teta)
        {
            Matrix mat = new Matrix(4,4);
            mat[0, 0] = 1;
            mat[1, 1] = Math.Cos(teta);
            mat[1, 2] = Math.Sin(teta);
            mat[2, 1] = -Math.Sin(teta);
            mat[2, 2] = Math.Cos(teta);
            mat[3, 3] = 1;
            return mat;
        }
        public static Matrix rotateOy(double teta)
        {
            Matrix mat = new Matrix(4, 4);
            mat[0, 0] = Math.Cos(teta);
            mat[0, 2] = -Math.Sin(teta);
            mat[2, 0] = Math.Sin(teta);
            mat[2, 2] = Math.Cos(teta);
            mat[1, 1] = 1;
            mat[3, 3] = 1;
            return mat;
        }
        public static Matrix rotateOz(double teta)
        {
            Matrix mat = new Matrix(4, 4);
            mat[0, 0] = Math.Cos(teta);
            mat[0, 1] = Math.Sin(teta);
            mat[1, 0] = -Math.Sin(teta);
            mat[1, 1] = Math.Cos(teta);
            mat[3, 3] = 1;
            mat[2, 2] = 1;
            return mat;
        }
        public static Matrix Translate(double x, double y, double z)
        {
            Matrix mat = new Matrix(4, 4);
            for (int i = 0; i < 4; i++)
            {
                mat[i, i] = 1;
            }
            mat[3, 0] = x;
            mat[3, 1] = y;
            mat[3, 2] = z;
            return mat;
        }

        public static Matrix Scaling(double value)
        {
            Matrix mat = new Matrix(4, 4);
            for (int i = 0; i < 3; i++)
            {
                mat[i, i] = 1;
            }
            mat[3, 3] = value;
            return mat;
        }
    }
}
