//Methods
//The PreBuild Functions That Helps To Run Our Code More Fast and Minimize The Code To Are Called Methods
//To Active These Methods We Have to Use Dot(.) After Keyword Char
//The Char with Capital C is Object and The char with Small c is data type both have properties

using System;

//Program To Find If There's Any Number in String
string? name;
int n = 0;
Console.Write("Enter Your Name: ");
name = Console.ReadLine();
foreach(char ch in name)
{
    if (!Char.IsLetter(ch))
    {
        n = 0;
        break;
    }   
    else
    {
        n = 1;
    }


}
if (n == 0)
{
    Console.WriteLine("String You Enter Have Numbers In It");
}
else
{
    Console.WriteLine("String You Enter Have Alphabetic Values Only In It");
}
//Program End


Console.ReadLine();