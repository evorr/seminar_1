// Программа на вход принимает два числа и проверяет, является ли
// первое число квадратом второго.
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int squ=num2*num2;
if (num1==squ)
{
    Console.WriteLine($"{num1} квадрат числа {num2}");
}
else
{
    Console.WriteLine($"{num1} не является квадратом числа {num2}");
}
