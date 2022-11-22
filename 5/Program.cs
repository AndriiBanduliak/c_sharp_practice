using static System.Console;
Clear();

WriteLine("enter sum of cash: ");
double n = double.Parse(ReadLine());
WriteLine("enter the pecent: ");
double m = double.Parse(ReadLine());
WriteLine("enter the price of the appartment: ");
double k = double.Parse(ReadLine());
WriteLine("enter the sum of the loan's percent: ");
double q = double.Parse(ReadLine());

int i = 0; //количество лет

if (q < m)
{
    while (n < k)
    {
        n = n + (n / (double)100 * m);
        k = k + (k / (double)100 * q);
        i++;
    }
    WriteLine("waiting " + i + " years");
}
else WriteLine("ahahahah");