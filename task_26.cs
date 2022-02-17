//Задача 26: Возведите число А в натуральную степень B, используя цикл.
Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine());
int count = 1;
int result = 1;
while (count <= B)
{
    result = result * A;
    count++;
}
Console.WriteLine(A + "^" + B + "=" + result + ".");
