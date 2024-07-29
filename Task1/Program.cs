// Задача 1.
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void Main()
{

                                     //Console.WriteLine("Введите натуральное число M: ");
    int m = 4;                      //int m = Convert.ToInt32(Console.ReadLine());
                                    //Console.WriteLine("Введите натуральное число N: ");
    int n = 15;                     //int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Натуральные числа от {m} до {n}:");
    Console.WriteLine(PrintNaturalNumbers(m, n));

}

string PrintNaturalNumbers(int m, int n)
{
    if (m == n) return Convert.ToString(n);
    return m + ", " + PrintNaturalNumbers(m + 1, n);
}

Main();