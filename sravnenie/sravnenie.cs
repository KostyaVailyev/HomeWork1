Console.Clear();
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.Write(num1 + " больше чем " + num2);
}
else if (num1 < num2)
{
    Console.Write(num1 + " меньше чем " + num2);
}
else
{
    Console.WriteLine("Оба числа равны");
}
Console.ReadKey();