// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.



int [,] array = new int[5,3]; 
void CreateArray()     //создаем массив
{
    for (int i = 0; i < array.GetLength(0); i++)    
    {   
        for (int j = 0; j < array.GetLength(1); j++)   
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
}

void PrintArray()      //выводим массив
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

Console.WriteLine("Введите номер строки");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца");
int num2 = Convert.ToInt32(Console.ReadLine());

void FindArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i==num && j==num2)
            {
                Console.WriteLine(array[i,j]);
            }
        }
    System.Console.WriteLine();
    }
}

CreateArray();
PrintArray();
FindArray();

