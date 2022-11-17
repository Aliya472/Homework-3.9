//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии. 
// N = 5 -> "5, 4, 3, 2, 1" 
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" 
 
 
//1.запрос числа. 
int num(string text) 
{ 
    Console.WriteLine("Введите "+text); 
    int N=Convert.ToInt32(Console.ReadLine()); 
    return N; 
} 
//2. вывод на печать числа n--=>1; 
void PrintNumTil_1(int num,int Point) 
{ 
    Console.Write(num+"  "); 
    if (num>Point)PrintNumTil_1(num-1,Point); 
} 
 
 
 
Console.Clear(); 
int N=num("число N"); 
int p=1; 
Console.WriteLine(); 
PrintNumTil_1(N,p);