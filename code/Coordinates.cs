using System;
using System.Collections.Generic;
using System.Text;

namespace PKG_6
{
    public class Coordinates
    {
        public Coordinates(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            coord = new Matrix(1, 4);
            coord[0, 0] = x;
            coord[0, 1] = y;
            coord[0, 2] = z;
            coord[0, 3] = 1;
        }

        public Coordinates(Matrix coord)
        {
            this.x = coord[0, 0];
            this.y = coord[0, 1];
            this.z = coord[0, 2];
            this.coord = coord;
        }

        public double x;
        public double y;
        public double z;
        public Matrix coord;
        public Coordinates AffineTransform(Matrix mat)
        {
            var result = coord * mat;
            if (result[0, 3] != 1)
            {
                for (int i = 0; i < 4; i++)
                {
                    result[0, i] /= result[0, 3];
                }
            }
            return new Coordinates(result);
        }
    }
}
