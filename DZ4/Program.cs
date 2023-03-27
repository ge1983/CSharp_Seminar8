// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] InputArray (int length1, int length2, int length3)
{
    int[,,] array = new int[length1, length2, length3];
    Random randon = new Random();
    for (int i = 0; i < length1; i++)
    {
        for (int j = 0; j < length2; j++)
        {
            for (int k = 0; k < length3; k++)
            {
                array[i,j,k] = randon.Next(10, 100);
            }
        }
    }
    return array;
}

void PrintArray (int[,,] array)
{
    for (int k = 0; k<array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i,j,k]}({i},{j},{k}) "); 
            }
             Console.WriteLine();
        }
    }
}


int[,,] array = InputArray(2,2,2);

Console.WriteLine("Полученный трехмерный массив");
PrintArray(array);