

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
    int number = 10002;
    int sum = 0;
    Console.Write($"Сумма цифр числа {number} равна ");
    Recursion(number);
    
    void Recursion(int num)
    {
        if (num % 10 == 0) return;
        int count = 0;
        count = count + num % 10;
        sum = sum + count;
        num = num / 10;
        Recursion(num);
    }
    Console.WriteLine(sum + ".");
}
//Task63();
//Task65();
Task67();