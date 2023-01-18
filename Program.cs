//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int lenght = GetArrayLenghtFromUser("Введите длину массива: ");
int[] array = GetRandomArray(lenght, 100, 1000);
int evenNumber = CountEvenNumbers(array);

Console.WriteLine("Выполняется создание массива... ");
Console.WriteLine();
Console.WriteLine($"[{String.Join(", ", array)}] -> {evenNumber}");

int GetArrayLenghtFromUser(string lenghtMessage)
{
    Console.Write(lenghtMessage);
    int userInput = int.Parse(Console.ReadLine() ?? "");
    return userInput;
}

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        result[i] = rnd.Next(minValue, maxValue);
    }
    return result;
}

int CountEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < lenght; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}