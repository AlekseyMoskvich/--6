/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/

Console.WriteLine("Введите сколько чисел вы хотите ввести");
int count = int.Parse(Console.ReadLine());
int[] array = new int[count];

InputArray(count);

int positive = GetCountOfPositiveNumbers(array);

Console.WriteLine($"Колличество положительных номеров = {positive}");

int[] InputArray(int count)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1}-й элемент");
        int num = int.Parse(Console.ReadLine());
        array[i] = num;
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(",", array));
}

int GetCountOfPositiveNumbers(int[] array)
{
    int positive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0){
            positive++;
        }
    }
    return positive;
}


/*Задача 43: Напишите программу, которая найдёт точку
пересечения двух прямых, заданных уравнениями
y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/