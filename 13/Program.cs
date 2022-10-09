// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// всего 2 решения задачи

Console.Write("Введите число ");
int n = int.Parse(Console.ReadLine());
if (n < 99)
{
    Console.Write("третьей цифры нет");
}
if (n > 99 && n < 999)
{
    n = (n % 10);
    Console.Write(n);
}
if (n > 999 && n < 9999)
{
    n = ((n / 10) % 10);
    Console.Write(n);
}
if (n > 9999 && n < 99999)
{
    n = ((n / 100) % 10);
    Console.Write(n);
}



//2 решение

// Console.Write("Введите число  ");
// int n = int.Parse(Console.ReadLine());
// int z = 99;
// int x = 1;
// if (n < z)
// {
//     Console.Write("третьей цифры нет");
//     break;
// }
// for (int i = 1; i < 20; i++)
// {
//     z = z + 900 * x;
//     //    Console.Write(z);
//     if (n < z)
//     {
//         n = ((n / x) % 10);
//         Console.Write(n);
//         break;
//     }
//     x = x * 10;
// }