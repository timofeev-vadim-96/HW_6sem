
// Задача 43
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

System.Console.WriteLine("Введите число");
int Numb = Convert.ToInt32(Console.ReadLine());
int left = 0;
if (Numb == 0) System.Console.WriteLine("0");
else if (Numb == 2) System.Console.WriteLine("10");
else if (Numb != 0 || Numb != 2)
{
    while (Numb!=0)
    {
        left = Numb%2;
        System.Console.Write(left);
        Numb = Numb/2;
    }
}

