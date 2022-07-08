// Программа, которая принимает на вход 2 числа и проверяет является ли первое квадратом второго

Console.Write ("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b*b)
{
    Console.WriteLine ($"Число {a} является квадратом числа {b}");
}
else 
{
     Console.WriteLine ($"Число {a} не является квадратом числа {b}");
}