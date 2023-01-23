/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */ 
  int GetNumbers(string messeng)
  {
    int result=0;
    Console.Write(messeng);
    while (true)
    {  if(int.TryParse(Console.ReadLine(), out result)) break;
    else Console.Write("Введите число для координаты->");
    }
    return result;
  }
int xa=GetNumbers("Введите координаты для 1 точки по X->");
int ya=GetNumbers("Введите координаты для 1 точки по Y->");
int za=GetNumbers("Введите координаты для 1 точки по Z->");
int xb=GetNumbers("Введите координаты для 2 точки по X->");
int yb=GetNumbers("Введите координаты для 2 точки по Y->");
int zb=GetNumbers("Введите координаты для 2 точки по Z->");
Console.Write($"Расстояние между точками ({xa},{ya},{za}) И ({xb},{yb},{zb}) ->{Math.Sqrt( Math.Pow(xb-xa,2)+ Math.Pow(yb-ya,2)+Math.Pow(zb-za,2)):f2}");                                                                                                                              
