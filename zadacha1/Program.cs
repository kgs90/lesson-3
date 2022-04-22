int [] x = new int [5];
x[0] = 10;
x[1] = 35;
x[2] = 100;
x[3] = 35;
x[4] = 10;
if (x[0] == x[4] && x[1] == x[3])
{
    System.Console.WriteLine("палиндром");
}
else
{
    System.Console.WriteLine("не палиндром");
}