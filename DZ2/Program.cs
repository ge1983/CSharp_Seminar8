// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int FindMinSumArray(int[,] array)
{
    int[] arraySum = new int[array.GetLength(0)];
    for (int i = 0; i<arraySum.Length; i++)
    {
        arraySum[i] = 0;
    }

    for (int i = 0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arraySum[i] += array[i,j];   
        }
    }

    int min = arraySum[0];
    int count = 0;
    for (int i = 1; i<arraySum.Length; i++)
    {
        if (arraySum[i] < min)
        {
            count = i;
            min = arraySum[i];
        }
    }
    
    return count + 1;
}

int[,] array = InputArray(4,4);

Console.WriteLine("Полученный двумерный массив");
PrintArray(array);

Console.WriteLine($"Cтрока с наименьшей суммой элементов - {FindMinSumArray(array)}");
