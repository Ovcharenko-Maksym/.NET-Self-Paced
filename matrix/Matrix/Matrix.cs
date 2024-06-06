using System;

namespace MatrixLibrary
{
    public class Matrix : ICloneable
    {
        private readonly double[,] array;

        public int Rows => array.GetLength(0);
        public int Columns => array.GetLength(1);

        public double[,] Array => array;

        public Matrix(int rows, int columns)
        {
            if (rows <= 0 || columns <= 0)
                throw new ArgumentOutOfRangeException(nameof(rows), "Rows and columns must be positive integers.");

            array = new double[rows, columns];
        }

        public Matrix(double[,] array)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            this.array = array;
        }

        public double this[int row, int column]
        {
            get
            {
                if (row < 0 || row >= Rows || column < 0 || column >= Columns)
                    throw new ArgumentException("Index is out of range.");

                return array[row, column];
            }
            set
            {
                if (row < 0 || row >= Rows || column < 0 || column >= Columns)
                    throw new ArgumentException("Index is out of range.");

                array[row, column] = value;
            }
        }

        public object Clone()
        {
            Matrix clonedMatrix = new Matrix(Rows, Columns);

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    clonedMatrix[i, j] = array[i, j];
                }
            }

            return clonedMatrix;
        }

        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns)
                throw new MatrixException("Matrices are not compatible for addition.");

            Matrix result = new Matrix(matrix1.Rows, matrix1.Columns);

            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Columns; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return result;
        }

        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns)
                throw new MatrixException("Matrices are not compatible for subtraction.");

            Matrix result = new Matrix(matrix1.Rows, matrix1.Columns);

            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Columns; j++)
                {
                    result[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }

            return result;
        }

        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Columns != matrix2.Rows)
                throw new MatrixException("Matrices are not compatible for multiplication.");

            Matrix result = new Matrix(matrix1.Rows, matrix2.Columns);

            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Columns; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < matrix1.Columns; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }
                    result[i, j] = sum;
                }
            }

            return result;
        }

        public Matrix Add(Matrix matrix)
        {
            return this + matrix;
        }

        public Matrix Subtract(Matrix matrix)
        {
            return this - matrix;
        }

        public Matrix Multiply(Matrix matrix)
        {
            return this * matrix;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Matrix otherMatrix = (Matrix)obj;

            if (Rows != otherMatrix.Rows || Columns != otherMatrix.Columns)
                return false;

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (array[i, j] != otherMatrix[i, j])
                        return false;
                }
            }

            return true;
        }
        public override int GetHashCode() => base.GetHashCode();
    }

    public class MatrixException : Exception
    {
        public MatrixException(string message) : base(message)
        {
        }
    }
}
