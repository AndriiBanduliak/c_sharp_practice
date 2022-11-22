using static System.Console;
Clear();

int a = Convert.ToInt32(Read());

if (a == 1)
{
    WriteLine("x > 0 and y > 0");
}
else if (a == 2)
{
    WriteLine("x < 0 and y > 0 ");
}
else if (a == 3)
{
    WriteLine("x < 0 and y < 0");
}
else
{
    WriteLine("x > 0 and y < 0");
}