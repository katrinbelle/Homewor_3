
/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

 int GetNumber (string messange)
 {
int result =0;
Console.Write(messange);
while(true)
{
    if (int.TryParse(Console.ReadLine(), out result)) break;
    else Console.WriteLine("Вы ввели не число, введите число ->");
}
return result;
 }
 int table=GetNumber("Введите число , чтобы начать выводить таблицу в кубе-> ");
for (int i=1; i<=table;i++)
 {  string  mark="->";
    if (i==table) mark=".";
    Console.Write(i*i*i+mark);
 }
