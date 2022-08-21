Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int a = number%2;
if ( a == 0 )
{
    Console.WriteLine ("Число " + number + " четное");
}
else
{
    Console.WriteLine ("Число " + number + " нечетное");
}