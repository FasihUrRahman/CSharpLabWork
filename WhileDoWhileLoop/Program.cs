int inputValue, i = 1; //Variables
Console.WriteLine("\tTable Generator"); //Title Message
Console.Write("Enter a Number To Generate Table: ");    //Input Message
inputValue = Convert.ToInt32(Console.ReadLine());   //Input
//While Loop Start
Console.WriteLine("Result With While Loop");
while (i <= 10) 
{
    Console.WriteLine($"{inputValue} x {i} = {inputValue * i}");    //Result
    i++;    //Increment
}
//While Loop End
Console.ReadLine();
//Do While Loop Start
i =  1; //Rest The Value of 'i'
Console.WriteLine("Result With Do While Loop");
do
{
    Console.WriteLine($"{inputValue} x {i} = {inputValue * i}");    //Result
    i++;
}
while (i <= 10);    //Condition
Console.ReadLine();