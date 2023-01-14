// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

 // Считать от пользователя данные
int GetNumberByUser(string text)
{
    Console.WriteLine(text + ": ");
    return Convert.ToInt32(Console.ReadLine());
}

// Создание массива
int[] CreateArray(int size)
{
   return new int[size+1]; 
}













 int countByUser = GetNumberByUser("Введите число");
int[] array = CreateArray(countByUser);