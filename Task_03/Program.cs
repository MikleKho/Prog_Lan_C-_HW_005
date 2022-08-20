// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
//элементов массива.
int Prompt(string message)
{
    System.Console.Write(message);
    string ReadValue = Console.ReadLine();
    int result = int.Parse(ReadValue);
    return result;
}

double[] Mass_rnd_inject(double[] Mass)
{
    Random rnd = new Random();
    System.Console.Write("Массив -->  ");

    for (int i = 0; i < Mass.Length; i++)
    {
        Mass[i] = Math.Round((rnd.NextDouble() * 100), 2);
        System.Console.Write($"  {Mass[i]}");
    }
    System.Console.WriteLine("");

    return Mass;
}

double Mass_Max_minus_Min(double[] Mass)
{
    double Mass_Max = Mass[0];
    double Mass_Min = Mass[0];

    for (int i = 1; i < Mass.Length; i++)
    {     
        if (Mass[i] > Mass_Max)
        {
            Mass_Max = Mass[i];
        }
        if (Mass[i] < Mass_Min)
        {
            Mass_Min = Mass[i];
        }
    }

    System.Console.WriteLine($"Максимальное значение --> {Mass_Max} Минимальное значение --> {Mass_Min}");
    return ((Mass_Max - Mass_Min));
}

int Mass_len = Prompt("Введите размер массива -->  ");
double[] Mass = new double[Mass_len];
Mass = Mass_rnd_inject(Mass);

// double[] Mass = new double[] {3, 7.4, 22.3, 2, 78};

double Mass_Diff = Math.Round(Mass_Max_minus_Min(Mass), 2);
System.Console.WriteLine($"Разница максимального и минимального значения в массиве --> {Mass_Diff}");
