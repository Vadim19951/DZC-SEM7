int m = InputInt(" Введите число строк: ");
int n = InputInt(" Введите число столбцов: ");
Console.WriteLine();
int column = 1;
int sum = 0;
int[,] array = new int[m,n];

FillArray(array);
PrintArray(array);
Average(array);

void FillArray(int[,] array)
{
   for( int i = 0; i < array.GetLength(0); i++)
   {
     for( int j = 0; j < array.GetLength(1); j++)
     {
        array[i,j] = new Random().Next(1,10);
        
     }
   }
}

void PrintArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
             Console.Write(array[i,j] + " " );

        }
        Console.WriteLine();
    }
}

int InputInt(string output)

{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void Average(int[,] array)
{
    for(int j = 0; j < array.GetLength(0); j++)
    {
        for(int i = 0; i < array.GetLength(1); i++)
      {
        sum += array[i,j];
      }
     Console.WriteLine("Среднне арифметическое столбца " + column + " равно: " + sum / array.GetLength(1));
     sum = 0;
     column++;
    }
}
