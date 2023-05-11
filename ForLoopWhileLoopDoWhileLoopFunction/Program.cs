//Function/Method
//Building a Function/Method is necessary when we have to use a method/function rapidly and frequently 
static void loopFunction() // Creating a function
{
    //Loops
    //When We Have to Perform single task again and again we rapidly we use Loop
    //For Loop
    //When We already knew the ending point we use for loop
    Console.WriteLine("\tLoops");
    Console.WriteLine("Writing Numbers From 1 to 10");
    Console.WriteLine("For Loop");
    int i = 0;
    for (i = 0; i < 10; i++)
    {
        Console.WriteLine($"After Running For Loop the Number is {i + 1}");
    }
    Console.ReadKey();
    //While Loop
    //We use While Loop When We Check a Condition is True and willing to do Work again and again until the loop is true
    i = 0;
    Console.WriteLine("While Loop");
    while (i < 10)
    {
        Console.WriteLine($"After Running While Loop the Number is {i + 1}");
        i++;
    }
    Console.ReadKey();
    //Do While
    //When we have to run Code atleste one time before checking the condition is true or false we use Do While Loop
    i = 0;
    Console.WriteLine("Do While Loop");
    do
    {
        Console.WriteLine($"After Running Do While Loop the Number is {i + 1}");
        i++;
    } while (i < 10);
    Console.ReadKey();
}


loopFunction(); //calling a function