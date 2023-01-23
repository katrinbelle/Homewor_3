/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */

int GetNumber (string message)
{
    int result = 0;
    Console.Write(message);
    while(true)
{
    if (int.TryParse(Console.ReadLine(), out result)&& result < 100000 && result > 9999) break;
    else Console.WriteLine("Введите пятизначное число, ранее ввели не то -> ");
}
return result;
}
 int number = GetNumber("Введите пятизначное число-> ");

    if (number/10000==number%10 && number/1000%10== number%100/10  ) Console.Write(" Число -> "+number+" является палиндромом");
 else Console.Write(" Число -> "+number+" не является палиндромом");