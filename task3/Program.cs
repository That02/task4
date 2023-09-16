//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

int[] numbers = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };


Console.WriteLine();
for (int i = 0; i < numbers.Length; i++)
{
 Console.Write(numbers[i] + " ");
}

Console.WriteLine();