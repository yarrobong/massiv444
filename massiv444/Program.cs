using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        int rows = 4;
        int columns = 4;

        int[,] array = new int[rows, columns];

        // Заполнение массива случайными числами и вывод на консоль
        Console.WriteLine("Двумерный массив случайных чисел:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = random.Next(1, 101);
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }


        // Нахождение суммы элементов всего массива
        int totalSum = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                totalSum += array[i, j];
            }
        }
        Console.WriteLine("Сумма элементов всего массива: " + totalSum);


        // Нахождение суммы элементов в каждой строке
        for (int i = 0; i < rows; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < columns; j++)
            {
                rowSum += array[i, j];
            }
            Console.WriteLine("Сумма элементов в строке " + (i + 1) + ": " + rowSum);
        }
        // Нахождение суммы элементов в каждом столбце
        for (int j = 0; j < columns; j++)
        {
            int columnSum = 0;
            for (int i = 0; i < rows; i++)
            {
                columnSum += array[i, j];
            }
            Console.WriteLine("Сумма элементов в столбце " + (j + 1) + ": " + columnSum);
        }

        // Нахождение суммы элементов в главной диагонали
        int mainDiagonalSum = 0;
        for (int i = 0; i < rows; i++)
        {
            mainDiagonalSum += array[i, i];
        }
        Console.WriteLine("Сумма элементов в главной диагонали: " + mainDiagonalSum);

        // Нахождение суммы элементов в побочной диагонали
        int secondaryDiagonalSum = 0;
        for (int i = 0; i < rows; i++)
        {
            secondaryDiagonalSum += array[i, rows - i - 1];
        }
        Console.WriteLine("Сумма элементов в побочной диагонали: " + secondaryDiagonalSum);
    }
}

