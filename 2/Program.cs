using static System.Console;
Clear();

Write("enter x1: ");
double a1 = Convert.ToDouble(ReadLine());

Write("enter x2: ");
double a2 = Convert.ToDouble(ReadLine());

Write("enter y1: ");
double b1 = Convert.ToDouble(ReadLine());

Write("enter y2: ");
double b2 = Convert.ToDouble(ReadLine());

double dist = Math.Sqrt(Math.Pow(a1 - b1, 2) + Math.Pow(a2 - b2, 2)); //квадратный корень((а2 - а1)2 +(в2 - в1)2)




WriteLine(dist);