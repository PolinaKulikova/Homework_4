// using static Library;

// // Напишите программу, которая выводит массив из N элементов,
// // заполненный нулями и единицами в случайном порядке.
// // Самое левое число != 0
// // Данный массив есть двоичное представление десятичного числа
// // [1,0,1,1,0,1,0,0]
// // Реализовать перевод двоичного числа в десятичное

// // 1. Ввод N
// // int <- (string)
int GetNumberByUser(string text)
{
    Console.Write(text +": ");
    return Convert.ToInt32(Console.ReadLine());
}

// // 2. Создание массива
// // int[] <- (int)
int[] CreateArray(int size);
{
    return new int[ size + 1] 
}

// // 3. Заполнение массива 0 и 1
// // void <- (int[])

// // 4. Печать массива
// // string <- (int[])

// // 5. Конвертация из 2-ого в 10-ое
// // int <- (int[])

// // 6. 10110100 >> 180
// // string <- (int[] , int)
// string GoodPrint(int[] bin, int dec)
// {
// return $"{String.Join("", bin)} >> {dec}";
// }

// Console.WriteLine(GoodPrint(new int[] { 1, 0, 1, 1, 1, 1, 0 }, 56));
