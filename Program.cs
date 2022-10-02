/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/
/*
Console.Write("Введите координаты точки Х1: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки Y1: ");
int y = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки Z1: ");
int z = int.Parse(Console.ReadLine());

Console.Write("Введите координаты точки Х2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки Y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки Z2: ");
int z2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x2-x,2) + Math.Pow(y2-y,2) + Math.Pow(z2-z,2));
Console.WriteLine($"Расстояние между точками равно -> result = {result:f2}");
*/


/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

/*
int number = ReadInt("Введите число N: ");

for(int index = 1; index <= number; index++)
{
    Console.Write($"{index*index*index} ");
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/

/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/


Console.Write("Введите число: ");
string number = Console.ReadLine()!;
if (number.Length == 5){
    if (number[0] == number[4] && number[1] == number[3])
    {
Console.Write("Число является палиндромом");
    }
    else
    {
Console.Write("Число не является палиндромом");
    }
    }
    else
    {
Console.Write("Введено неверное число"); 
    }

    