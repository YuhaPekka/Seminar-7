// Задача 2.
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// A(m, n)
// n + 1, при m = 0;
// A(m - 1, 1), при m > 0, n = 0;
// A(m - 1, A(m, n - 1)), при m > 0, n > 0;

void Main()
{
    int m = 3;
    int n = 5;

    Console.WriteLine($"A({m}, {n}) = {AkkerFunc(m, n)}");
}

int AkkerFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return AkkerFunc(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return AkkerFunc(m - 1, AkkerFunc(m, n - 1));
    }
    return(AkkerFunc(m,n));

}

Main();