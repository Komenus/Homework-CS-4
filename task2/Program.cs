// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
void countnumber(int n)
{
    int r = 0;
    while(n > 0)
    {
        r = r + n % 10;
        n = n / 10;
    }
    Console.WriteLine($"Сумма чисел равна {r} ");
}
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
countnumber(num);
