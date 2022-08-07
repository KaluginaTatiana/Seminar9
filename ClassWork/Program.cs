void FillArray(int[,] array)
{
    Random rand = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(0, 5);
        }
    }
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Task63()
{
    // Задайте значение N. Напишите программу, которая выведет все натуральные
    // числа в промежутке от 1 до N.

    int num = 15;
    int count = 1;
    Recursion(count, num);
    Console.WriteLine();

    void Recursion(int count, int number)
    {
        if (count > number) return;
        Console.Write(count + " ");
        count++;
        Recursion(count, number);
    }

    /*while (count <= num)
    {
        Console.Write(count + " ");
        count++;
    }
    Console.WriteLine();*/
}

void Task65()
{
    // Задайте значения M и N. Напишите программу, которая выведет все
    // натуральные числа в промежутке от M до N.
    int num1 = 15;
    int num2 = 25;
    Recursion(num1, num2);
    Console.WriteLine();

    void Recursion(int n, int m)
    {
        if (n > m) return;
        Console.Write(n + " ");
        n++;
        Recursion(n, m);
    }
}

void Task67()
{
    // Напишите программу, которая будет принимать на вход число и возвращать
    // сумму его цифр.
    int number = 113001;
    int sum = 0;
    Console.Write($"Сумма цифр числа {number} равна ");
    Recursion(number);
    
    void Recursion(int num)
    {
        if (num == 0) return;
        sum = sum + num % 10;
        num = num / 10;
        Recursion(num);
    }
    Console.WriteLine(sum + ".");
}

void Task69()
{
    // Напишите программу, которая на вход принимает два числа A и B, и возводит 
    // A в целую степень B с помощью рекурсии.
    Console.WriteLine("Введите целое число - основание степени.");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите целое число - показатель степени.");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Recursion(num1, num2);
    void Recursion(int a, int b, int p = 1)
    {
        if (b == 0) 
        {
            Console.WriteLine($"Результат возведения числа {num1} в степень {num2} равен {p}.");
            return;
        }
        p = p * a;
        b--;
        Recursion(a, b, p);
    }  
}

void Task61()
{
    // Задайте две матрицы. Напишите программу, которая будет находить
    // произведение двух матриц.
    
    Random rand = new Random();
    int rowsFirst = rand.Next(3, 5);
    int columnsFirst = rand.Next(3, 5);
    int rowsSecond = columnsFirst;
    int columnsSecond = rand.Next(3, 5);

    int[,] arrayFirst = new int[rowsFirst, columnsFirst];
    int[,] arraySecond = new int[rowsSecond, columnsSecond];
    int[,] result = new int[rowsFirst,columnsSecond];

    FillArray(arrayFirst);
    FillArray(arraySecond);
    PrintArray(arrayFirst);
    PrintArray(arraySecond);

    for (int i = 0; i < rowsFirst; i++)
    {
        for (int j = 0; j < columnsFirst; j++)
        {
            for (int k = 0; k < rowsSecond; k++)
            {
                result[i, j] += arrayFirst[i, k] * arraySecond[k, j];
            }
        }
    }
    PrintArray(result);
}
//Task63();
//Task65();
//Task67();
//Task69();
Task61();