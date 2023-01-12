// ### Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// #### 452 -> 11
// #### 82 -> 10
// #### 9012 -> 12

// Console.WriteLine("Введите число");
// int UserNumber = Convert.ToInt32(Console.ReadLine());
// string SumNumber = UserNumber.ToString();

// int SumOfNumber()

// Console.WriteLine(second[1]);

// // int GetNumberByUser(string text)
// // {
// //     Console.Write(text +": ");
// //     return Convert.ToInt32(Console.ReadLine());
// // }

Console.WriteLine("Введите число");
int UserNumber = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int UserNumber){
    
    int digitsOfNumbers = Convert.ToString(UserNumber).Length;
    int advance = 0;
    int result = 0;

    for (int count = 0; count < digitsOfNumbers; count++){
      advance = UserNumber - UserNumber % 10;
      result = result + (numberN - advance);
      numberN = numberN / 10;
    }
   return result;
  }

int sumNumber = SumNumber(numberN);
Console.WriteLine(SumNumber);