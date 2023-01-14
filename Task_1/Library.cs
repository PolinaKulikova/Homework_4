public static class Library
{
// Считать от пользователя данные
public static int GetNumberByUser(string text)
{
    Console.WriteLine(text + ": ");
    return Convert.ToInt32(Console.ReadLine());
}

// Создание массива
public static int[] CreateArray(int size)
{
   return new int[size+1]; 
}
 
 // Метод заполнения массива случайными числами от 0 до 1
 public static void FillArray(int[] collection)      
{
    int length = collection.Length;
    int index = 1;
    collection[0] = 1;
    while (index < length)
    {
        collection[index] = Random.Shared.Next(2); 
        index++;
    }
}

//  Метод печати массива
public static string PrintArray(int[] collection)     
{
    string output = String.Empty;
    int size = collection.Length;
    for (int i = 0; i < collection.Length; i++)
    {
        output = output + $"{collection[i]} ";
    }
    return output;
} 
// Конвертация в десятичную из двоичной
public static int toDecimal(int[] collection)              
{
int count = collection.Length;
int exponent = collection.Length - 1; 
int result = 0;
for (int i = 0; i < collection.Length; i++)
{
    if (collection[i] == 1)
    {
        result += Convert.ToInt32(Math.Pow(2, exponent));
    }
    exponent--;
}
return result;
}

// Красивая печать результата
public static string GoodPrint(int[] collection, int dec)     
{
    return $"{String.Join("", collection)} >> {dec}";
}

} 