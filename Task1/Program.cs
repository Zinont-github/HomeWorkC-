Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if ( a < b )
{
    Console.WriteLine("Число " + b + " больше");
    Console.WriteLine("Число " + a + " меньше");
}
else if ( a > b )
{
    Console.Write("Число " + a + " больше");
    Console.Write("Число " + b + " меньше");
}
else if ( a == b )
{
    Console.Write("Числа равны");
}
