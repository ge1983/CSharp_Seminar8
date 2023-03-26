//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


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


int[,] SortArray (int[,] array)
{
    int z = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = array.GetLength(1)-1; j > 0; j--)
        {
            for (int k = 0; k < j; k++)
            {
                if (array[i,k] < array[i,k+1])
                {
                    z = array[i,k];
                    array[i,k] = array[i,k+1];
                    array[i,k+1] = z;

                }
            }
        }
    }
    return array;
}

int[,] array = InputArray(7,7);

Console.WriteLine("Полученный двумерный массив");
PrintArray(array);

Console.WriteLine("Отсортированный массив");
PrintArray(SortArray (array));
