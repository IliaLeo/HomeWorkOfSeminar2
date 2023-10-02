// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n == 6 || n == 7) {
    Console.WriteLine("да");
}
else if (n > 7) {
    Console.WriteLine("Дней в неделе всего 7");
}
else {
    Console.WriteLine("нет");
}