// See https://aka.ms/new-console-template for more information

using System.Runtime.Serialization;

Console.Write("Enter a number: ");
int userNumber = int.Parse(Console.ReadLine());
string evenOdd = " ";
if (userNumber % 2 == 0)
{
    evenOdd = "even";
}
else
{
    evenOdd = "Odd";
}

if (userNumber > 0)
{
    Console.WriteLine("The number is {0} and positive",evenOdd );
}
else if (userNumber < 0)
{
    Console.WriteLine("The number is {0} and negetive",evenOdd);
}
else
{
    Console.WriteLine("The number is {0} and nutral",evenOdd);
}