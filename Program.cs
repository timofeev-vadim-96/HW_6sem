// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
System.Console.WriteLine("Введите количество цифр, которое вы будете вводить");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int [N];
int count = 0;
for (int i = 0; i < N; i++)
{
    System.Console.WriteLine($"Введите {i+1} число");
    array [i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0) count++;
}
System.Console.WriteLine($"Введенные числа: {String.Join(", ", array)}");
System.Console.WriteLine($"Количество введенных положительных чисел: {count}");

