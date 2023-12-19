// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

int [,] array = new int [5,3];
CreateArray();
void CreateArray()     
{
    for (int i = 0; i < array.GetLength(0); i++)    
    {   
        for (int j = 0; j < array.GetLength(1); j++)   
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
}
PrintArray();
void PrintArray()      
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j] +" ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

minSumLine();

int minSumLine()
{
    int min = int.MaxValue;
    int minSumLine = 0;
    for(int i = 0; i<array.GetLength(0); i++)
    {
        int sum = array[0,0];
        for(int j = 0; j<array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        if(sum<min)
        {
            min=sum;
            minSumLine = i;
        }
    }
return minSumLine;
}
Console.WriteLine($"Строка с минимальной суммой элементов: {minSumLine()}");

