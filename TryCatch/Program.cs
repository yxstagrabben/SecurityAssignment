// See https://aka.ms/new-console-template for more information

using System;

Console.WriteLine("If you want security press 1 then enter if you dont want security press enter");
string? chooseSecurity = Console.ReadLine();
string? input1;
string? input2;
Console.WriteLine("Input a number that is not zero and not a decimal number!");
input1 = Console.ReadLine();
Console.WriteLine("Input a second number that is not zero and not a decimal number!");
input2 = Console.ReadLine();
if (chooseSecurity == "1")
{
    WithSecurity(input1, input2);
}
else
{
    WithOutSecurity(input1, input2);
}

static void WithSecurity(string? str1, string? str2)
{
    try
    {
        if (str1 != null || str2 != null)
        {
            int num1 = int.Parse(str1);
            int num2 = int.Parse(str2);
            Console.WriteLine("Your numbers multiplied is: " + num1 * num2);
        }
        else
        {
            FallbackSecurity();
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("Wrong input " + e.Message);
        FallbackSecurity();
    }
    finally
    {
        Console.ReadKey();
    }
}

static void WithOutSecurity(string? str1, string? str2)
{
    int num1 = int.Parse(str1);
    int num2 = int.Parse(str2);
    Console.WriteLine("Your numbers multiplied is: " + num1 * num2);
    Console.ReadKey();
}

static void FallbackSecurity()
{
    string? input1;
    string? input2;
    Console.WriteLine("You put in something other than a number that is not zero and not a decimal number! Try Again!");
    Console.WriteLine("Input a number that is not zero and not a decimal number!");
    input1 = Console.ReadLine();
    Console.WriteLine("Input a number that is not zero and not a decimal number!");
    input2 = Console.ReadLine();
    WithSecurity(input1, input2);
}