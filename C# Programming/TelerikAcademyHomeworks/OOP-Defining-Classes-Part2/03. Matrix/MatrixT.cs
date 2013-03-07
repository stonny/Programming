using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Matrix<T> where T : IComparable
{
    // Fields
    private T[,] matrix;
    public int col;
    public int row;

    // Constructor
    public Matrix(int col, int row)
    {
        this.col = col;
        this.row = row;
        this.matrix = new T[col, row];
    }

    // Indexer
    public T this[int rowPosition, int colPosition]
    {
        get
        {
            return matrix[rowPosition, colPosition];
        }

        set
        {
            matrix[rowPosition, colPosition] = value;
        }
    }
    // Methods
    public override string ToString()
    {
        StringBuilder matrixString = new StringBuilder();
        for (int i = 0; i <row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                matrixString.Append(string.Format("{0,5}", matrix[i, j]) + " ");
            }

            matrixString.AppendLine("\n");
        }

        return matrixString.ToString();
    }
    // Operators
        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
    {
        Matrix<T> finalMatrix = new Matrix<T>(firstMatrix.row, firstMatrix.col);
        if (firstMatrix.col == secondMatrix.col && firstMatrix.row == secondMatrix.row)
        {
            
            for (int i = 0; i < firstMatrix.row; i++)
            {
                for (int j = 0; j < firstMatrix.row; j++)
                {
                    dynamic tempValueOne = firstMatrix[i, j];
                    dynamic tempValueTwo = secondMatrix[i, j];
                    finalMatrix[i, j] = tempValueOne + tempValueTwo;
                }
            }
        }
        else
        {
            throw new ArgumentException("The size of the matrixes are not the same !");
        }

        return finalMatrix;
    }

    public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
    {
        Matrix<T> finalMatrix = new Matrix<T>(firstMatrix.row, firstMatrix.col);
        if (firstMatrix.col == secondMatrix.col && firstMatrix.row == secondMatrix.row)
        {
            for (int i = 0; i < firstMatrix.row; i++)
            {
                for (int j = 0; j < firstMatrix.row; j++)
                {
                    dynamic tempValueOne = firstMatrix[i, j];
                    dynamic tempValueTwo = secondMatrix[i, j];
                    finalMatrix[i, j] = tempValueOne - tempValueTwo;
                }
            }
        }
        else
        {
            throw new ArgumentException("The size of the matrixes are not the same !");
        }

        return finalMatrix;
    }

    public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
    {
        Matrix<T> finalMatrix = new Matrix<T>(firstMatrix.row, firstMatrix.col);
        for (int i = 0; i < finalMatrix.row; i++)
        {
            for (int j = 0; j < finalMatrix.col; j++)
            {
                for (int multiCol = 0; multiCol < firstMatrix.col; multiCol++)
                {
                    for (int k = 0; k < firstMatrix.col; k++)
                    {
                        dynamic tempValueOne = firstMatrix[i, j];
                        dynamic tempValueTwo = secondMatrix[i, j];
                        finalMatrix[i, j] += tempValueOne * tempValueTwo;
                    }
                }
            }
        }
        return finalMatrix;
    }
    public static bool operator true(Matrix<T> matrix)
    {
        if (matrix == null || matrix.row == 0 || matrix.col == 0)
        {
            return false;
        }

        for (int row = 0; row < matrix.row; row++)
        {
            for (int col = 0; col < matrix.col; col++)
            {
                if (!matrix[row, col].Equals(default(T)))
                {
                    return true;
                }
            }
        }

        return false;
    }

    public static bool operator false(Matrix<T> matrix)
    {
        if (matrix == null || matrix.row == 0 || matrix.col == 0)
        {
            return true;
        }

        for (int row = 0; row < matrix.row; row++)
        {
            for (int col = 0; col < matrix.col; col++)
            {
                if (!matrix[row, col].Equals(default(T)))
                {
                    return false;
                }
            }
        }

        return true;
    }
}