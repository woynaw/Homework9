Console.WriteLine("Введите N");
int number = Convert.ToInt32(Console.ReadLine());


void Counter(int number)
{
    if (number < 0) Console.Write($"{number} не натуральное число");
    if (number == 0) return;
    Console.Write($"{number} ");
    Counter (number - 1);
}
Console.Write($"N = {number} -> ");
Counter(number);