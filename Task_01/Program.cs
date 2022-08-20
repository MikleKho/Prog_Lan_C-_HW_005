// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите 
// программу, которая покажет количество чётных чисел в массиве.

int Prompt(string message)
{
    System.Console.Write(message);
    string ReadValue = Console.ReadLine();
    int result = int.Parse(ReadValue);
    return result;
}

int[] Mass_rnd_inject(int[] Mass)
{
    Random rnd = new Random();
    System.Console.Write("Массив -->  ");

    for (int i = 0; i < Mass.Length; i++)
    {
        Mass[i] = rnd.Next(100, 1000);
        System.Console.Write($"  {Mass[i]}");
    }
    System.Console.WriteLine("");

    return Mass;
}

int Mass_Even_count(int[] Mass)
{
    int Mass_Even_counter = 0;

    for (int i = 1; i < Mass.Length; i++)
    {
        if (Mass[i] % 2 == 0)
        {
            Mass_Even_counter++;
        }
    }

    return (Mass_Even_counter);
}

int Mass_len = Prompt("Введите размер массива -->  ");
int[] Mass = new int[Mass_len];
Mass = Mass_rnd_inject(Mass);
int Mass_Even_counter = Mass_Even_count(Mass);
System.Console.WriteLine($"Количество четных чисел в массиве --> {Mass_Even_counter}");
