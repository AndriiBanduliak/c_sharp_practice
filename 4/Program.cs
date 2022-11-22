using static System.Console;
Clear();

Write("enter number: ");
int number = Convert.ToInt32(ReadLine());

int centr = number / 2 + 1;
int left = centr - 1;
int right = centr + 1;

if (number > 0)
{


    for (int i = 1; i <= centr; i++)
    {

        for (int j = 0; j <= number; j++)
        {
            if (left < j && right > j)
                Write("*");
            else
                Write(" ");
        }
        left--; 
        right++;
        WriteLine();
    }
}
else
{
    Write("Дурачок введи положительное число");
}
