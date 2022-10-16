using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
namespace ConsoleApp2
{
class Program
    {

static double line1(double x)
{
    double y;
    y = 0;
    return y;
}
static double line2(double x)
{
    double y;
    y = x + 7;
    return y;
}
static double line3(double x)
{
    double y;
    y = 4;
    return y;
}
static double parabola(double x)
{
    double y;
    y = x * x;
    return y;
}
static double line4(double x)
{
    double y;
    y = - 2 * x + 8;
    return y;
}

static void Main()
{ 
for (double x = -7; x <= 9; x += 0.2)
{
    if (x < -9)
    {
        Console.WriteLine("Функция не определена.");
    }
    else if (x < -7)
    {
        Console.WriteLine("y({0:0.00}) = {1:0.00}", x, line1(x));
    }
    else if (x < -3)
    {
        Console.WriteLine("y({0:0.00}) = {1:0.00}", x, line2(x));
    }
    else if (x < -2)
    {
        Console.WriteLine("y({0:0.00}) = {1:0.00}", x, line3(x));
    }
    else if (x < 2)
    {
        Console.WriteLine("y({0:0.00}) = {1:0.00}", x, parabola(x));
    }
    else if (x < 4)
    {
        Console.WriteLine("y({0:0.00}) = {1:0.00}", x, line4(x));
    }
    else if (x < 7)
    {
        Console.WriteLine("y({0:0.00}) = {1:0.00}", x, line1(x));
    }
}
}
        }
    }

