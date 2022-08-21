Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
if ( a > b & a > c)
{
    Console.WriteLine("Число " + a + " большее");
}
else if ( b > a & b > c )
{
    Console.WriteLine("Число " + b + " большее");
}
else if ( c > a & c > b )
{
    Console.WriteLine("Число " + c + " большее");
}
