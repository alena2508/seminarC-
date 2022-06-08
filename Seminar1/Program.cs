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

int N, current; 

Console.WriteLine("введите целое число: ");
N = Convert.ToInt32(Console.ReadLine());

while (N - 1 == 0)
{
   N = N - 1;
   Console.WriteLine(" N ");
}
