using System;
using System.Collections.Generic;
using System.Text;


namespace PKG_6
{
    public class Matrix
    {
        public Matrix(int rows, int columns)
        {
            matrix = new double[rows, columns];
            row_count = rows;
            column_count = columns;
            initialize(); 
        }                
        public Matrix(double[,] matrix, int rows, int columns)
        {
            this.matrix = matrix;
            row_count = rows;
            column_count = columns;
            initialize();
        }
        public double this[int x, int y]
        {
            get
            {
                return this.matrix[x, y];
            }
            set
            {
                this.matrix[x, y] = value;
            }
        }
        void initialize()
        {
            for (int i = 0; i < row_count; i++)
            {
                for (int j = 0; j < column_count; j++)
                {
                    matrix[i, j] = 0;
                }
            }
        }
        double[,] matrix;
        public int row_count;
        public int column_count;
        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a.column_count != b.row_count)
            {
                throw new ArgumentException("Invalid matrices");
            }
            Matrix mat = new Matrix(a.row_count, b.column_count);
            for (int k = 0; k < b.column_count; k++) {
                for (int i = 0; i < a.row_count; i++)
                {
                    for (int j = 0; j < b.row_count; j++)
                    {
                        mat[i,k] += a[i, j] * b[j, k];
                    }
                }
            }
            return mat;
        }
        public static Matrix operator+ (Matrix a, Matrix b)
        {
            if (a.row_count != b.row_count || a.column_count != b.column_count) {
                throw new ArgumentException("Invalid matrices");
            }
            Matrix mat = new Matrix(a.row_count, a.column_count);
            for (int i = 0; i <  a.row_count; i++)
            {
                for (int j = 0; j < a.column_count; j++)
                {
                    mat[i, j] = a[i, j] + b[i, j];
                }
            }
            return mat;
        }
        public static Matrix operator *(double a, Matrix b)
        {
            Matrix mat = new Matrix(b.row_count, b.column_count);
            for (int i = 0; i < b.row_count; i++)
            {
                for (int j = 0; j < b.column_count; j++)
                {
                    mat[i, j] = a * b[i, j];
                }
            }
            return mat;
        }
        public static Matrix T(Matrix a)
        {
            Matrix mat = new Matrix(a.column_count, a.row_count);
            for (int i = 0; i < mat.row_count; i++)
            {
                for (int j = 0; j < mat.column_count; j++)
                {
                    mat[i, j] = a[j, i];
                }
            }
            return mat;
        }
    }
}
