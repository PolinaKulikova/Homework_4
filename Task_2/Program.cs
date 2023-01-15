// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetNumberByUser(string text)                      // Получили число от пользователя
{
    Console.WriteLine(text + ": ");
    return Convert.ToInt32(Console.ReadLine());
}

int SumOfNumbers(int countByUser)                     // Разбили по разрядам , переведя в строку
{
    int count = Convert.ToString(countByUser).Length;
    int shift = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
      shift = countByUser - countByUser % 10;
      result = result + (countByUser - shift);
      countByUser = countByUser / 10;
    }
   return result;
  }

int countByUser = GetNumberByUser("Введите число, если хочешь узнать сумму его цифр");
int sum = SumOfNumbers(countByUser);
Console.WriteLine(sum);
