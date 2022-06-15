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

/*на вход пятизначное число и проверяет, является ли оно палиндромом* чтобы не спутаться, буду всё расписывать стихийным методом, без упрощения*/

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

/* принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве*/

double FindLeght (double xA, double yA, double zA, double xB, double yB, double zB)
{
   Convert.ToDouble(x, y, z);
   return Math.Pow((xA - xB),2) + Math.Pow((yA - yB),2) + Math.Pow((zA - zB),2);
}

/* принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.*/
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
