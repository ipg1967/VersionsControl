
/* Console.WriteLine("введите число: ");
 int number = Convert.ToInt32(Console.ReadLine());
 int result = number * number;
System.Console.WriteLine("квадрат числа равен :" + result); 

Console.WriteLine("введите число 1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число 2");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 * number2)
{
Console.WriteLine("число" );
}
else
{
Console.WriteLine("числа");
}


System.Console.WriteLine("введите число дня недели");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 1)
{
    System.Console.WriteLine("понедельник");
}
else if (day == 2)
{
    System.Console.WriteLine("вторник");
}
else if (day == 3)
{
    System.Console.WriteLine("среда");
}
else if (day == 4)
{
    System.Console.WriteLine("четверг");
}
else if (day == 5)
{
    System.Console.WriteLine("пятница");
    }
else if (day == 6)
{
    System.Console.WriteLine("суббота");
}
else if (day == 7)
{
    System.Console.WriteLine("воскресенье ");
}
else 
{
System.Console.WriteLine("такого дня нет");
}


System.Console.WriteLine("введите число");
int number = Math.Abs(Convert.ToInt32(System.Console.ReadLine()));
// int number = Convert.ToInt32(System.Console.ReadLine());
// if (number < 0) 
//{
//    number = - number;
//}

int index = -number;
// через while 
// while(index <= number)
// {
// System.Console.Write(index + " ");
// index++;
// }

// через for
for(int i = -number; i <=number; i++) 
{
System.Console.Write(i + " ");
}
System.Console.WriteLine(""); */

// задача на вывод единиц из трехзначного числа 
System.Console.WriteLine("Введите трехзначное число:");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1>99 && number1 < 1000) 
{
System.Console.WriteLine(number1%10); // символ взятия остатка от деления на число - %
}
else
{
    System.Console.WriteLine("Введено не трехзначное число");
}
