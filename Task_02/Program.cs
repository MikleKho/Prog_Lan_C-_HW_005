// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих 
// на нечётных позициях.
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
        Mass[i] = rnd.Next(0, 100);
        System.Console.Write($"  {Mass[i]}");
    }
    System.Console.WriteLine("");

    return Mass;
}

int Mass_OddPoint_count(int[] Mass)
{
    int Mass_OddPoint_counter = 0;

    for (int i = 0; i < Mass.Length; i += 2) // Началом нечетных позиций считаю Mass[0] - первый элемент массива 
    {
        Mass_OddPoint_counter = Mass_OddPoint_counter + Mass[i];
    }

    return (Mass_OddPoint_counter);
}

int Mass_len = Prompt("Введите размер массива -->  ");
int[] Mass = new int[Mass_len];
Mass = Mass_rnd_inject(Mass);
int Mass_OddPoint_counter = Mass_OddPoint_count(Mass);
System.Console.WriteLine($"Сумма чисел в массиве по нечетным позициям --> {Mass_OddPoint_counter}");
