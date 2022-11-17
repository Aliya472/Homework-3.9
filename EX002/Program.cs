//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// M = 1; N = 15 -> 120 
// M = 4; N = 8. -> 30 
 
//1.запрос числа. 
int num(string text) 
{ 
    Console.WriteLine("Введите "+text); 
    int N=Convert.ToInt32(Console.ReadLine()); 
    return N; 
} 
//2. вывод на печать числа n--=>1; 
 
int SumNaturFrom_M_to_N(int num,int Point,int Sum) 
{ 
    if (num==Point) return Sum+=Point; 
    if (num>Point) 
    { 
        Console.Write(Sum+"  "); 
        return SumNaturFrom_M_to_N(num-1,Point,Sum+=num); 
    } 
    else return  SumNaturFrom_M_to_N(num+1,Point,Sum+=num); 
} 
 
 
 
Console.Clear(); 
Console.WriteLine("Программа,ищет сумму натуральных элементов в промежутке от M до N"); 
int M=num("число M"); 
int N=num("число N"); 
Console.WriteLine(); 
int S1=0; 
int S=SumNaturFrom_M_to_N(M,N,S1); 
Console.WriteLine($"Cумму натуральных элементов в промежутке от M до N = {S}");