// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру обозначающую день недели, и мы узнаем, является ли этот день выходным ");
int x = int.Parse(Console.ReadLine());
if (x < 1 || x > 7)
{
    Console.Write("такого дня нет в неделе");
}
if (x > 0 && x < 6) 
{
    Console.Write("нет");
}
if (x > 5 && x < 8)
{
    Console.Write("да");
}