// Задача 3.
// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

void Main()
{
    int[] array = { 8, 12, 37, 0, 4 };
    ReverseArr(array, array.Length - 1);


}

void ReverseArr(int[] array, int i)
{
    if (i < 0) return;
    Console.Write(array[i] + " ");
    ReverseArr(array, i - 1);
}

Main();

