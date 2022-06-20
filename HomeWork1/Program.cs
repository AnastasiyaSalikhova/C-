/*Задача 2
*int num1, num2, max;


Console.Write("Imput ferst integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Imput  second integer number: ");
num2 = Convert.ToInt32(Console.ReadLine());

max = num1;

if (num1>max) max = num1;
if (num2> max) max = num2;

Console.Write("max = ");
Console.WriteLine(max);
*/
/*Задача 4*/

/*int num1, num2, num3, max;


Console.Write("Imput ferst integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Imput second integer number: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Imput integer number: ");
num3 = Convert.ToInt32(Console.ReadLine());

max = num1;

if (num1>max) max = num1;
if (num2> max) max = num2;
if (num3>max) max = num3;

Console.WriteLine(max);
*/
//Задача 6

/*int num;

Console.Write("Imput number: ");
num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
*/

//Задача 8

int num;

Console.Write("Imput number: ");
num = Convert.ToInt32(Console.ReadLine());

int current = num / 2;


while(current < num)
{
    Console.Write(current + " ");
    current++;
}



