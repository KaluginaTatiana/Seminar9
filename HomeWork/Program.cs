void Task64()
{
    // Задайте значения M и N. Напишите программу, которая выведет 
    // все натуральные числа в промежутке от M до N, кратные трём.
    int num1 = 1;
    int num2 = 30;
    Recursion(num1, num2);
    Console.WriteLine();

    void Recursion(int m, int n)
    {
        if (m > n) return;
        if (m % 3 == 0)
        {
            Console.Write(m + " ");
        }
        m++;
        Recursion(m, n);
    }
}

void Task66()
{
    // Задайте значения M и N. Напишите программу, которая найдёт 
    // сумму натуральных элементов в промежутке от M до N.
    int num1 = 1;
    int num2 = 10;
    Recursion(num1, num2);

    void Recursion(int m, int n, int sum = 0)
    {
        if (m > n)
        {
            Console.WriteLine($"Сумма натуральных чисел в промежутке от {num1} до {num2} равна {sum}.");
            return;
        }
        sum = sum + m;
        m++;
        Recursion(m, n, sum);
    }
}

void Task68()
{
    // Напишите программу вычисления функции Аккермана с помощью рекурсии. 
    // Даны два неотрицательных числа m и n.
    int m = 3;
    int n = 2;
    Console.WriteLine($"Результат функции Аккермана А({m},{n}) равен {Ackerman(m, n)}."); 

    int Ackerman(int m, int n)
    { 
    if (m == 0) 
    {
        return n + 1;
    }
    else if (m > 0 && n == 0) 
    {
        return Ackerman(m - 1, 1);
    }
    else 
    {
        return Ackerman(m-1, Ackerman(m, n-1)); 
    }
    }
}

Task64();
Task66();
Task68();