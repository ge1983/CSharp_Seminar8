// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] InputArray (int length1, int length2)
{
    int[,] array = new int[length1, length2];
    Random randon = new Random();
    for (int i = 0; i < length1; i++)
    {
        for (int j = 0; j < length2; j++)
        {
            array[i,j] = randon.Next(1, 10);
        }
    }
    return array;
}

void PrintArray (int[,] array)
{
    for (int i = 0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");  
        }
        Console.WriteLine();
    }
}

int[,] MmultiplicationArray (int[,] A, int[,] B)
{
    int[,] newArray = new int[A.GetLength(0), B.GetLength(1)];
    for(int i = 0; i < newArray.GetLength(0); i++)
    {
        
        for(int j = 0; j < newArray.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < A.GetLength(1); k++)
            {
                sum += A[i,k] * B[k,j];
            }
            newArray[i,j] = sum;
        }
    }
    return newArray;
}


int[,] A = InputArray(2,2);
Console.WriteLine("Исходная матрица A");
PrintArray(A);

int[,] B = InputArray(2,2);
Console.WriteLine("Исходная матрица B");
PrintArray(B);

Console.WriteLine("Матрица произведения А и В");
PrintArray(MmultiplicationArray(A, B));

