int m = InputInt(" Введите число строк: ");
int n = InputInt(" Введите число столбцов: ");
Console.WriteLine();
int[,] array = new int[m,n];

FillArray(array);
PrintArray(array);

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


int i = InputInt(" Введите координаты строки: ");
int j = InputInt(" Введите координаты столбца: ");

if(i >= array.GetLength(0) || j >= array.GetLength(1))
{
    Console.WriteLine("В данном массиве числа с такими координатами не существует!");
}           
else
{
  Console.WriteLine("Число по введенным координатам: " + array[i,j]);
}