// 1 определяю сколько строк в массиве хочет ввести пользователь, задаю размер массива 
static int InputInteger(string size)
{
    Console.Write(size+":");
    if (int.TryParse(Console.ReadLine(), out int value))
    return value;
    return InputInteger(size);
}