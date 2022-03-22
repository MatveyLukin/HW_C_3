/*
//Задача №1
// Условие: Написать программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int GetQuart(double xPoint, double yPoint)
{
    if (xPoint > 0 && yPoint > 0) return 1;
    if (xPoint < 0 && yPoint > 0) return 2;
    if (xPoint < 0 && yPoint < 0) return 3;
    if (xPoint > 0 && yPoint < 0) return 4;
    return 0;
}

double x, y;
int quartNum;
Console.Write("Input X: ");
x = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y: ");
y = Convert.ToDouble(Console.ReadLine());

quartNum = GetQuart(x, y);
if (quartNum == 0) Console.WriteLine("Нельзя однозначно определить четверть");
else Console.WriteLine("Данная точка находится в " + quartNum + " четверти");


//Задача №2
// Условие: Написать программу, которая принимает на вход номер четверти и выводит на экран диапазон координат, доступных в этой четверти

void GetQuart(int quartNum)
{
    switch (quartNum)
    {
        case 1:
            {
                Console.WriteLine("В данной четверти координаты могут быть в следующем диапазоне: X > 0, Y > 0");
                break;
            }
        case 2:
            {
                Console.WriteLine("В данной четверти координаты могут быть в следующем диапазоне: X < 0, Y > 0");
                break;
            }
        case 3:
            {
                Console.WriteLine("В данной четверти координаты могут быть в следующем диапазоне: X < 0, Y < 0");
                break;
            }
        case 4:
            {
                Console.WriteLine("В данной четверти координаты могут быть в следующем диапазоне: X > 0, Y < 0");
                break;
            }
        default:
            {
                Console.WriteLine("Введены неверные значения");
                break;
            }

    }

}
int limit;
Console.Write("Ведите номер четверти (число от 1 до 4) ");
limit = Convert.ToInt32(Console.ReadLine());
GetQuart(limit);


//Задача №1
// Условие: Написать программу, принимающую на вход координаты двух точек и определяющую расстояние между ними

double Getdistance(double x1, double y1, double x2, double y2)
{
    double xDistance = (x1 - x2);
    double yDistance = (y1 - y2);

    return Math.Sqrt(Math.Pow(xDistance, 2) + Math.Pow(yDistance, 2));
}


double xA, yA, xB, yB;
double distance;
Console.Write("Input X of point A: ");
xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y of point A: ");
yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input X of point A: ");
xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y of point A: ");
yB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Getdistance(xA, yA, xB, yB));

*/

/*

//Домашняя работа С# 3_1
// Условие: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


void Polindrom(int num)
{
    int num1 = num / 10000;
    int num2 = num / 1000 % 10;
    int num4 = num % 100 / 10;
    int num5 = num % 10;
    if (num < 100000 && num > 9999)
    {


        if (num1 == num5 && num2 == num4)
        {
            Console.WriteLine("Число является палиндромом");
        }
        else
        {
            Console.WriteLine("Число не является палиндромом");
        }
    }
    else
    {
        Console.WriteLine("Введённые данные не отвечают условиям задачи");
    }
}

Console.WriteLine("Введите пятизначное число ");
int limit = Convert.ToInt32(Console.ReadLine());
Polindrom(limit);


//Домашняя работа С# 3_2
// Условие: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


double Getdistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double xDistance = (x2 - x1);
    double yDistance = (y2 - y1);
    double zDistance = (z2 - z1);

    return Math.Sqrt(Math.Pow(xDistance, 2) + Math.Pow(yDistance, 2) + Math.Pow(zDistance, 2));
}


double xA, yA, zA, xB, yB, zB;
double distance;
Console.Write("Input X of point A: ");
xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y of point A: ");
yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Z of point A: ");
zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input X of point B: ");
xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y of point B: ");
yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Z of point B: ");
zB = Convert.ToDouble(Console.ReadLine());


Console.WriteLine(Getdistance(xA, yA, zA, xB, yB, zB));


//Домашняя работа С# 3_3
// Условие: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cubes(double limit)
{
    int counter = 1;
    while (counter <= limit)
    {
        Console.WriteLine("Таблица кубов в заданном диапазоне" + Math.Pow(counter, 3));
        counter++;
    }

}

Console.WriteLine("Введите число ");
double N = Convert.ToDouble(Console.ReadLine());
Cubes(N);

*/