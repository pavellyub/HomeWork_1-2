// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int Even;

if (number %2 == 0)
{
    Console.WriteLine("Это число четное");
} 
else
{
    Console.WriteLine("Это число нечетное");
}