void Delenie(int num)
{
    if(num % 7 == 0 && num % 23 == 0)
    {
        System.Console.WriteLine("OK");
    } else
    {
        System.Console.WriteLine("NO");
    }
}
System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Delenie(number);