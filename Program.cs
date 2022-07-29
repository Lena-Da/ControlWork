// 1 определяю сколько строк в массиве хочет ввести пользователь, задаю размер массива 
static int InputInteger(string size)
{
    Console.Write(size+":");
    if (int.TryParse(Console.ReadLine(), out int value))
    return value;
    return InputInteger(size);
}

// 2 ввод значений в массив
static string[] InputArray(int count)
{
string[] NewArray = new string[count];
Console.WriteLine($"Введите любые значения в {count} строк(и)");
    for (int i = 0; i < count; i++)
        {
            Console.Write($"{i+1} ");
            NewArray[i] = Console.ReadLine();
        }
    return NewArray;
}