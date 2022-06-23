/*
int num, result;
Console.Write( "введите целое число ");
num = Convert.ToInt32(Console.ReadLine());
result = num * num;
Console.WriteLine("Результатик: " + result);
*/

/* ДЗ*/
/*
int num1, num2;
Console.WriteLine("введите целое число: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите ещё одно целое число: ");
num2 = Convert.ToInt32(Console.ReadLine());
if(num1 < num2)
{
    Console.WriteLine( "Большее число: " + num2 );
}
else
{
    Console.WriteLine( "Большее число: " + num1 );
}
*/

/*
int num1, num2, num3, max;
Console.WriteLine("введите поочерёдно три числа: ");
num1 = Convert.ToInt32(Console.ReadLine());
num2 = Convert.ToInt32(Console.ReadLine());
num3 = Convert.ToInt32(Console.ReadLine());
max = num1;
if(num1 < num2) max = num2;
if(num2 < num3) max = num3;
Console.WriteLine( "Большее число: " + max );
*/

/*
int num, current;
Console.WriteLine("введите целое число: ");
num = Convert.ToInt32(Console.ReadLine());
current = num / 2;
current ++;
if(current == 1) Console.WriteLine(" Число нечётное");
else
{
Console.WriteLine("Число чётное: ");
}
*/

/*int N, current; 
Console.WriteLine("введите целое число: ");
N = Convert.ToInt32(Console.ReadLine());
while (N - 1 == 0)
{
   N = N - 1;
   Console.WriteLine(" N "); /* увы, не могу понять, как выводить каждое значение N
}
current = N / 2;
current ++;
if(current == 0) Console.WriteLine(" current, "); */

/* ДЗ Семинар 2*/
/* на вход трёхзначное число и на выходе показывает вторую цифру
int CutNum()
{
    int num = new Random ().Next(100, 999);
    Console.WriteLine($"выбранное число: {num}");
    int sot = num / 10;
    int result = sot % 10;
    return result;
}
выводит третью цифру заданного числа или сообщает, что третьей цифры нет
int CutThreeNum (int num)
{
    int num, result;
    Console.WriteLine("введите любое целое число: ");
    num = Convert.ToInt32(Console.ReadLine());
    if (num < 100) Console.WriteLine(" третья цифра отсутствует ");
    if (num > 100);
    result = num / 10;
    return result;
}
/*принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
int WeekDays ()
{
    int num;
    Console.WriteLine("введите цифру дня недели (1-7) ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num >= 6)
    {
        return "True"; 
    }
    else
    {
        return "False";
    }
}
*/
/*на вход пятизначное число и проверяет, является ли оно палиндромом* чтобы не спутаться, буду всё расписывать стихийным методом, без упрощения
int FindPoliandrom ()
{
    int num;
    Console.WriteLine ("введите любое пятизначное число: ");
    num = Convert.ToInt32(Console.ReadLine());
    int num5 = num % 10;
    int num4 = num % 100;
    int num2 = num % 10000;
    int num1 = num % 100000;
        if (num1 == num5 && num2 == num4)
        {
         Console.WriteLine("True");
        }
        else
        {
          Console.WriteLine("False");
        }
}

принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

double FindLeght (double xA, double yA, double zA, double xB, double yB, double zB)
{
   Convert.ToDouble(x, y, z);
   return Math.Pow((xA - xB),2) + Math.Pow((yA - yB),2) + Math.Pow((zA - zB),2);
}

принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void FindCube(int num)
{
    int current = 1;
    while (current <= num)
    {
        Console.Write((current * current * current) + " ");
        current++;
    }
}
Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());

FindCube(num)
*/


/*принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int Stepen (int A, int B);
int current = 1; current++;
while (current <= B);
{
Console.WriteLine (A * A);
}

задаёт массив из 8 элементов и выводит их на экран.  не сказано ведь, что программа запрашивает числа, значит рандом...*/
/*
int size = 8;
int [] array = new int [size];
for (int i = 0; i < size; i = i +1)
{
    array[i] = new Random().Next(0, 999);
}
for (int i = 0; i < size; i = i +1)
{
    Console.WriteLine (array[i] + " ");
}
*/

/*Задайте массив из случайных полож. трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i ++);
    {
        newArray[i] = new Random().Next(min = 100, max = 1000);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    return newArray;
}
int FindCountEvenSum(int[] array, int min, int max)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count ++;
    }
    return count;
}

/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i ++);
    {
        newArray[i] = new Random().Next(min, max);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    return newArray;
}
int FindSumNOTEven(int[] array, int min, int max, int step)
{
    int sum = 0;
    int step = 2;
    for(int i = 1; i < array.Length; i + step)
    {
        if(array[i] % 2 == 1) sum ++;
    }
    return sum;
}*/

/*Задайте массив вещественных(дробных, см. Random().NextDouble()) чисел. Найдите разницу между макс и мин ЗНАЧЕНИЯМИ элементов массива

double[] CreateRandomDoudleArray(int size)
{
    double[] newArray = new double[size];
    for(int i = 0; i < size; i ++);
    {
        newArray[i] = new Random().NextDouble();
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    return newArray;
}
int FindDiffMaxMin(double[] array, double minNum, double maxNum, double result)
{
    double minNum = array[i];
    double maxNum = array[i];

        for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < minNum)
        {
            minNum = array[i];
        }
         if(array[i] > maxNum)
        {
            maxNum = array[i];
        }
    }
    Console.WriteLine(maxNum);
    Console.WriteLine(minNum);

    double maxNum - double minNum = result;
    return result;
}*/

ДЗ#6
/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь*/

int FindPositivNum(int[] array)
{
    int count = 0;
    for( int i=0; i < array.Length; i++)
    {
        if( array[i] > 0) count++;
    }
    return count;
}
Console.WriteLine("введите несколько любых целых чисел: ");
int array = Convert.ToInt32(Console.ReadLine());

/*Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.*/

int ArrayCopyStepByStep(int[] array)
{
    int SecondArray = 0;
    for( int i=0; i < array.Length; i++)
    {
        if( array[i] > 0) count++;
    }
    return count;
}