// Напишите программу, которая заполнит спирально массив 4 на 4

void PrintArray (int[,] array)
{
    string str = "";
    for (int i = 0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < 10)
            {
                str = "0" + array[i,j].ToString();
                Console.Write($"{str} "); 
            }
            else
            {
                Console.Write($"{array[i,j]} ");
            }
              
        }
        Console.WriteLine();
    }
}
int[,] InputArray (int length)
{
    int[,] array = new int[length, length];
    int count = 1;
    int k = 0;
    for (int ki = 0; ki < length; ki++)
    {
        for (int j = 0; j < length; j++)
        {
            array[ki,j] = 0;
        }
    }
    
    if (length % 2 == 0)
    {
        k = length / 2;
    }
    else
    {
       k = length / 2 + 1; 
    }

    for (int i = 0; i < k; i++)
    {
  
        for (int j = i; j < length -i; j++)
        {
            array[i,j] = count;
            count++;
        }
        for (int j = i+1; j < length - i -1; j++)
        {
            array[j,length - i - 1] = count;
            count++;
        }
        for (int j = length -1 -i; j > i; j--)
        {
            array[length - i - 1,j] = count;
            count++;
        }
        for (int j = length - 1 - i; j > i; j--)
        {
            array[j,i] = count;
            count++;
        }

   }
    return array;
}

Console.WriteLine("Введите размерность массива");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = InputArray(n);

Console.WriteLine("Полученный двумерный массив");
PrintArray(array);