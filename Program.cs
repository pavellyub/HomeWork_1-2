// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите ваше число (положительное): ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
    Console.WriteLine("Вы ввели неверное число");

int count = 2;
while (count <= number)
{
    Console.Write(count + " ");
    count = count + 2;
}