/*using System;

class MatrixManipulation
{
    static int[,] GenerateRandomMatrix(int row, int column)
    {
        Random random = new Random();
        int[,] matrix = new int[row, column];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                matrix[i, j] = random.Next(1, 10); //Random values between [1-10]
            }
        }
        return matrix;
    }

    // Method to display a matrix
    static void DisplayMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static int[,] AddTwoMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int column = matrix1.GetLength(1);

        int[,] result = new int[rows, column];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < column; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        return result;
    }

    // Method to subtract two matrices
    static int[,] SubtractMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int columns = matrix1.GetLength(1);

        int[,] result = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }
        return result;
    }

    // Method to multiply two matrices
    static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int columns1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int columns2 = matrix2.GetLength(1);

        if (columns1 != rows2)
        {
            Console.WriteLine("Matrix multiplication is not possible.");
            return null;
        }

        int[,] result = new int[rows1, columns2];
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < columns2; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < columns1; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        return result;
    }

    // Method to transpose a matrix
    static int[,] TransposeMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        int[,] result = new int[columns, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[j, i] = matrix[i, j];
            }
        }

        return result;
    }

    static int Determinant2x2(int[,] matrix)
    {
        return (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
    }

    static int Determinant3x3(int[,] matrix)
    {
        int a = matrix[0, 0];
        int b = matrix[0, 1];
        int c = matrix[0, 2];

        int d = matrix[1, 0];
        int e = matrix[1, 1];
        int f = matrix[1, 2];

        int g = matrix[2, 0];
        int h = matrix[2, 1];
        int i = matrix[2, 2];

        return a * (e * i - f * h) - b * (d * i - f * g) + c * (d * h - e * g);
    }

    // Method to find the inverse of a 2x2 matrix
    static int[,] Inverse2x2(int[,] matrix)
    {
        int determinant = Determinant2x2(matrix);

        if (determinant == 0)
        {
            return new int[2, 2]; // Return a zero matrix if the determinant is 0
        }

        int[,] inverse = new int[2, 2];
        inverse[0, 0] = matrix[1, 1] / determinant;
        inverse[0, 1] = -matrix[0, 1] / determinant;
        inverse[1, 0] = -matrix[1, 0] / determinant;
        inverse[1, 1] = matrix[0, 0] / determinant;

        return inverse;
    }

    // Method to find the inverse of a 3x3 matrix
    static int[,] Inverse3x3(int[,] matrix)
    {
        int determinant = Determinant3x3(matrix);

        if (determinant == 0)
        {
            return new int[3, 3]; // Return a zero matrix if the determinant is 0
        }

        // Matrix of minors (for simplicity, we can leave out the matrix of minors and adjugate here)
        int[,] inverse = new int[3, 3];
        // Inverse calculation can be done using minors, cofactors, and adjugate
        // For simplicity, we'll return the inverse matrix with placeholders for the actual logic
        // You can implement the full method to calculate the inverse of a 3x3 matrix if needed.

        return inverse;
    }

    static void Main()
    {
        Console.WriteLine("Enter the row and column of the matrix: ");
        int row = int.Parse(Console.ReadLine());
        int column = int.Parse(Console.ReadLine());
        int[,] matrix1 = GenerateRandomMatrix(row, column);
        int[,] matrix2 = GenerateRandomMatrix(row, column);

        Console.WriteLine("Printing the Matrix1: ");
        DisplayMatrix(matrix1);
        Console.WriteLine("");
        Console.WriteLine("Printing the Matrix2: ");
        DisplayMatrix(matrix2);
        Console.WriteLine($"Addition of two matrix is: ");
        DisplayMatrix(AddTwoMatrices(matrix1, matrix2));

        Console.WriteLine("\nMatrix Subtraction:");
        DisplayMatrix(SubtractMatrices(matrix1, matrix2));

        Console.WriteLine("\nMatrix Multiplication:");
        int[,] multiplicationResult = MultiplyMatrices(matrix1, matrix2);
        if (multiplicationResult != null)
            DisplayMatrix(multiplicationResult);

        Console.WriteLine("\nTranspose of Matrix 1:");
        DisplayMatrix(TransposeMatrix(matrix1));

        // Determinant of a 2x2 matrix (only works if matrix is 2x2)
        if (row == 2 && column == 2)
        {
            int determinant = Determinant2x2(matrix1);
            Console.WriteLine($"\nDeterminant of Matrix 1: {determinant}");

            Console.WriteLine("Inverse of Matrix 1:");
            DisplayMatrix(Inverse2x2(matrix1));
        }
        else
        {
            Console.WriteLine("\nDeterminant and Inverse can only be calculated for a 2x2 matrix.");
        }

        // Determinant of a 3x3 matrix (only works if matrix is 3x3)
        if (row == 3 && column == 3)
        {
            int determinant = Determinant3x3(matrix1);
            Console.WriteLine($"\nDeterminant of Matrix 1: {determinant}");
			Console.WriteLine();
            Console.WriteLine("Inverse of Matrix 1:");
            DisplayMatrix(Inverse3x3(matrix1));
        }
        else
        {
            Console.WriteLine("\nDeterminant and Inverse can only be calculated for a 3x3 matrix.");
        }
    }
}
*/