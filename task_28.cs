// Задача 28: Подсчитайте сумму цифр в числе.
Console.WriteLine("Введите число: ");
string num = Console.ReadLine();
int number = Convert.ToInt32(num);
int sum = 0;
while (number > 0)
{
    int n = number % 10;
    sum = sum + n; 
    number = number / 10;

} 
Console.WriteLine("Сумма цифр в числе равна " + sum + ".");
