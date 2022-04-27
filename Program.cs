

//ДЗ №9
// Треугольник Паскаля. Создать программу построения и вывода на экран.

int[,] GreateTriangie(int size)
{
    int[,] triangel = new int[size, size];
    for (int i = 0; i < size; i++)
    {
        triangel[i, 0] = 1;
        triangel[i, i] = 1;
    }
    for (int i = 2; i < size; i++)
    {
        for (int y = 1; y < size; y++)
        {
            triangel[i, y] = triangel[i - 1, y - 1] + triangel[i - 1, y];
        }
    }
    PrintArray(triangel);
    return triangel;
}
GreateTriangie(7);

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write(new String(' ', (matr.GetLength(0) - i) * 4));
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] == 0)
            {
                Console.Write($"");
            }
            else
            {
                Console.Write("{0,8}", matr[i, j]);
                // увеличивая 8 -- сдвигаем вершину к центру консоли, шаг 2.
                // при этом увеличиваем кратно множитель в консоли string(8->4, 10->5 ...)            
            }
        }
        Console.WriteLine();
    }
}




