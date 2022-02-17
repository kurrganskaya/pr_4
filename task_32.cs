// Задача 32: Задайте массив из восьми элементов, заполненных нулями и единицами. Выведите их на экран

int [] array = new int [8];
int index = 0; 
int length = array.Length;
while (index < array.Length)
    {
        Console.WriteLine();
        Console.WriteLine(array [index] = new Random().Next(0, 2));
        index++;
    }
