Console.WriteLine("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine());
int a = number * 0 + 1;
while (a <= number)
{
    if (a%2 == 0)
    {
        Console.Write(a + " ");
    }    
    a++;
}
