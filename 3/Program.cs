using static System.Console;
Clear();


WriteLine("Введите массу арбуза, который купили парниши: ");
double weith = Convert.ToDouble(ReadLine());

if (weith % 2 != 0)
{
    WriteLine("не повезло не фартануло, ребятки");
}
else    //четное 
{
    for (int i = 2; i < weith; i += 2)
    {
        double a = weith - i;
        WriteLine(i.ToString() + " " + a.ToString());
    }

}

