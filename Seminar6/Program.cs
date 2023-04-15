/*Задача 40: Напишите программу, которая принимает на вход три числа и
проверяет,может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон.*/

/*
Console.WriteLine("Введите три числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());



void KnowTrianglePosible(int a, int b, int c)
{
    if(a < b + c && b < a + c && c < a + b){
        Console.WriteLine("Треугольник возможен");
    }
    else{
        Console.WriteLine("Треугольник не возможен");
    }
}


KnowTrianglePosible(a, b, c);
*/

/*Задача 42: Напишите программу, которая будет преобразовывать 
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

string ConvertTo2(int number)
{
    int delitel = 2;
    while(delitel > 1){
        int i = 0;
        i++;
        string convetring = "";
        

    }
}



/*Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

//Console.WriteLine("Введите сколько чисел фибоначи вы хотите увидеть");
//int count = int.Parse(Console.ReadLine());

void Fibonachi(int count)
{
    int[] array = new int[count];
    array[0] = 0;
    Console.Write($"{array[0]} ");
    array[1] = 1;
    Console.Write($"{array[1]} ");
    for (int i = 2; i < count; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
        Console.Write($"{array[i]} ");
    }
}

//Fibonachi(count);

/*Задача 45: Напишите программу, которая будет создавать копию 
заданного массива с помощью поэлементного копирования.
*/

void GenerateArray(int[] array)
{
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 10);
    }
}

void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(",", array));
}

int[] GetCoppyOfArray(int[] array)
{
    int[] array2 = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array2[i] = array[i];
    }
    return array2;
}
/*
int[] array = new int[5];

GenerateArray(array);
PrintArray(array);

int[] second = GetCoppyOfArray(array);

PrintArray(second);
*/