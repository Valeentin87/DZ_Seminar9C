// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
int result = A(n, m);
Console.WriteLine(result);
int A(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return A(n - 1, 1);
    if (n > 0 && m > 0) return A(n - 1, A(n, m - 1));
    return A(n, m);
}

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("Введите число M");
double M = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число N");
double N = Convert.ToDouble(Console.ReadLine());
if (M < 0 & N < 1) Console.WriteLine("на заданном числовом интервале натуральные числа отсутствуют)");

int result = SummaNaturalsNumber(M, N);
Console.WriteLine();
Console.WriteLine(result);

int SummaNaturalsNumber(double leftValue, double rightValue)
{
    int nFirstNaturalNumber = 1;
    int summa = 0;
    int nLastNaturalNumber = Convert.ToInt32(Math.Round(rightValue, 0));
    if (leftValue < 1 & rightValue > 1)
    {
        for (int i = 1; i <= nLastNaturalNumber; i++)
        {
            summa = summa + i;
        }
        
    }
    if (leftValue >= 1 & rightValue > 1)
    {
        nFirstNaturalNumber = Convert.ToInt32(Math.Round(leftValue, 0));
        for (int i = nFirstNaturalNumber; i <= nLastNaturalNumber; i++)
        {
            summa = summa + i;
        }
        
    }
    return summa;
}

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Console.WriteLine("Введите число M");
double M = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число N");
double N = Convert.ToDouble(Console.ReadLine());
if (M < 0 & N < 1) Console.WriteLine("на заданном числовом интервале натуральные числа отсутствуют)");

string result = NaturalsNumber(M , N);
Console.WriteLine();
Console.WriteLine(result);

string NaturalsNumber(double leftValue, double rightValue)
{
    int nFirstNaturalNumber = 1;
    string naturals = String.Empty;
    int nLastNaturalNumber = Convert.ToInt32(Math.Round(rightValue, 0));
    if (leftValue < 1 & rightValue > 1)
    {
        for (int i = 1; i <= nLastNaturalNumber; i++)
        {
            string j = Convert.ToString(i);
            naturals = naturals + j + " ";
        }
    }
    if (leftValue > 1 & rightValue > 1)
    {
        nFirstNaturalNumber = Convert.ToInt32(Math.Round(leftValue, 0));
        for (int i = nFirstNaturalNumber; i <= nLastNaturalNumber; i++)
        {
            string j = Convert.ToString(i);
            naturals = naturals + j + " ";
        }
    }
    return naturals;
}

   

