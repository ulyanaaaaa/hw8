// Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }
// string FromNToOne(int a, int b)
// {
//     if (a <= b) return FromNToOne(a+1, b) + $"{a}, ";
//     else return String.Empty;
// }

// int n = InputNum("Enter N number: ");
// Console.Write($"N = {n} -> ");
// Console.Write(FromNToOne(1, n));



// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

// int FromNToM(int n, int m)
// {
//     int sum = 0;
//     while (n <= m)
//     {
//         sum = sum + n;
//         n = n + 1;
//     }
//     return sum; 
// }

// int n = InputNum("Enter N number: ");
// int m = InputNum("Enter M number: ");
// Console.Write($"Summary from {n} to {m} = ");
// Console.Write(FromNToM(n, m));



// Задача 68: Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int Akkerman(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0 && n > 0)
    {
        return Akkerman(n - 1, 1);
    }
    else
    {
        return (Akkerman(n - 1, Akkerman(n, m - 1)));
    }
}

void AkkermanFunction(int n, int m)
{
    Console.Write(Akkerman(n, m)); 
}

int n = InputNum("Enter positive N number: ");
int m = InputNum("Enter positive M number: ");
if (n < 0 ^ m < 0)
{
    Console.WriteLine("Please, enter positive numbers.");
}
else 
{
    AkkermanFunction(n, m);
}