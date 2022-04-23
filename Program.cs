
/////////////////////////////////////////////////////////////////////////////////////

ДЗ №8

// Задача 1: Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 10);
        }
    }
}

int[,] SortArray(int[,] arra)
{
    for (int i = 0; i < arra.GetLength(0); i++)
    {
        for (int j = 0; j < arra.GetLength(1) - 1; j++)
        {
            int minPos = j;
            for (int k = j + 1; k < arra.GetLength(1); k++)
            {
                if (arra[i, k] < arra[i, minPos])
                {
                    minPos = k;
                }
            }
            int temp = arra[i, j];
            arra[i, j] = arra[i, minPos];
            arra[i, minPos] = temp;
        }
    }
    return arra;
}
int[,] matrix = new int[3, 3];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
SortArray(matrix);
Console.WriteLine();
PrintArray(SortArray(matrix));
*/

///////////////////////////////////////////////////////////////////////////////////////

//Задача 2: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 10);
        }
    }
}




int[,] SumLine(int[,] matr)//Метод нахождения суммы элементов строк
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j];
        }
        Console.Write(sum + " ");
    }
    return matr;
}
int[,] matrix = new int[3, 3];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
SumLine(matrix);
Console.WriteLine();
//PrintArray(SumLine(matrix));
*/

///////////////////////////////////////////////////////////////////////////////////////

//Заполните спирально массив 4 на 4.

//Задача №4. Заполните спирально массив 4 на 4.
/*
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    int count = 1;
    int i = 0;
    int j = 0;
    int col = matr.GetLength(0);
    int row = matr.GetLength(1);
    for (j = 0; j < col; j++)
    {
        matr[i, j] = count++;
    }
    for (i = 1; i < col; i++)
    {
        j = row - 1;
        matr[i, j] = count++;
    }
    for (j = row - 2; j >= 0; j--)
    {
        i = col - 1;
        matr[i, j] = count++;
    }
    for (i = col - 2; i >= 1; i--)
    {
        j = 0;
        matr[i, j] = count++;
    }
    for (j = 1; j < row - 1; j++)
    {
        i = 1;
        matr[i, j] = count++;
    }
    for (j = row - 2; j >= 1; j--)
    {
        i = 2;
        matr[i, j] = count++;
    }
}

int[,] matrix = new int[4, 4];

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

*/

/////////////////////////////////////////////////////////////////////////////////////////////
//Задача № 3.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//массив размером 2 x 2 x 2

/*
void PrintArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]} {(i, j, k)} ");
            }
            Console.WriteLine();
        }
    }
}
void FillArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {

                matr[i, j, k] = new Random().Next(10, 100);
            }
        }

    }
}


int[,,] matrix = new int[2, 2, 2];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

*/




