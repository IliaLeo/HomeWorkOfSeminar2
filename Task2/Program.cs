// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n / 100 > 0 && n / 100 < 10) {
    int n1 = n % 10;
    Console.WriteLine(n1);
}
else if (n / 100 == 0) {
    Console.WriteLine("третьей цифры нет");
}
else {
    int n2 = n / 100;
    int n3 = n2 % 10;
    Console.WriteLine(n3);
}
 

