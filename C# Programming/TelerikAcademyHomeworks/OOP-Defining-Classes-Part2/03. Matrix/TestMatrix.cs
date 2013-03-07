using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TestMatrix
{
    static void Main(string[] args)
    {

        // Intialiazing Matrix
        Matrix<int> testMatrixOne = new Matrix<int>(10, 10);
        Matrix<float> testMatrixTwo = new Matrix<float>(3, 2);
        Matrix<int> testMatrixThree = new Matrix<int>(10, 10);

        // Filling Matrix One 
        for (int i = 0; i < testMatrixThree.col; i++)
        {
            for (int j = 0; j < testMatrixThree.row; j++)
            {
                testMatrixThree[i, j] = i + j;
            }
        }
        // Filling Matrix Three
        for (int i = 0; i < testMatrixOne.col; i++)
        {
            for (int j = 0; j < testMatrixOne.row; j++)
            {
                testMatrixOne[i, j] = (i + j)*2;
            }
        }
        // Testing matrix +
        Console.WriteLine("Matrix +");
        Console.WriteLine(testMatrixOne + testMatrixThree);
        // Testing matrix -
        Console.WriteLine("Matrix -");
        Console.WriteLine(testMatrixOne - testMatrixThree);
        // Testing matrix *
        Console.WriteLine("Matrix *");
        Console.WriteLine(testMatrixThree * testMatrixOne);
    }
}
