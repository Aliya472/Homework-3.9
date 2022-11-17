//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 9 
// m = 3, n = 2 -> A(m,n) = 29 
 
 
//1.запрос числа. 
int num(string text) 
{ 
    Console.WriteLine("Введите "+text); 
    int N=Convert.ToInt32(Console.ReadLine()); 
    return N; 
} 
//2. вывод на печать числа n--=>1; 
 
double Ackerman_M_to_N(int M,double N) 
{ 
     
    if (M!=0&&N==0)return Ackerman_M_to_N(M-1,1); 
    else if (M>0&&N>0)return Ackerman_M_to_N(M-1,Ackerman_M_to_N(M,N-1)); 
    return N +1; 
} 
 
 
Console.Clear(); 
Console.WriteLine("Программу вычисляет функцию Аккермана с помощью рекурсии Для M & N"); 
int M=num("число M"); 
int N=num("число N"); 
Console.WriteLine(); 
int A=0; 
double S=Ackerman_M_to_N(M,N); 
Console.WriteLine($"Результат вычисления функции Аккермана с помощью рекурсии Для M & N = {S}");