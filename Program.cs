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

// 3 вывожу массивы на экран
static void Print(string size,string[] Array)
{
    if(size!=null)
    Console.WriteLine(size);
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]}" + " ");
    }
    Console.WriteLine();
}


// 4 определяю сколько строк содержит до трех символов
static string[] Result(string[] Array)
{
    string NewArray = "";
    for (int i = 0; i < Array.Length; i++)
    if (Array[i].Length <= 3) 
    NewArray +=(NewArray==""?"":"|")+Array[i];
    return NewArray.Split('|'); 
}