//Compund Formulas
//Compund Formulas are Those which are Complex Formulas in Maths. Here in C# We Use Some Math Classes To Perform Those Functional Work
//Example For Compund Formulas
//valueOne = ((valueInput)^2) x 10
float valueInput, valueOne;
Console.Write("Enter a Number To get it's Value>>");
valueInput = Convert.ToInt32(Console.ReadLine());   //Input Value For Complex Formula
valueOne = (float)(Math.Pow(valueInput, 2) * 10); //Complex Formula (((valueInput)^2) x 10)
Console.WriteLine($"Value of Input is {valueInput} And The Answer For ((Input Value)^2)x10 = {valueOne}"); //OutPut For Complex Formula
//Example Two For Different Formula
valueOne = (float)(Math.Sin(Math.Pow(valueInput, 2) * 10)); //Complex Formula (((valueInput)^2) x 10)
Console.WriteLine($"Value of Input is {valueInput} And The Answer For (Sin((Input Value)^2)x10) = {valueOne}"); //OutPut For Complex Formula

Console.ReadLine();
//Conditions
//If Else If Else
//it work's on the places where we need to check the argument is true or false and what code it run's on true or false statement
int ageUserValue;
string nameUserValue;
Console.Write("Enter Your Name: ");
nameUserValue = Console.ReadLine()?? "Someone";
Console.Write("Enter Your Age: ");
ageUserValue = Convert.ToInt32(Console.ReadLine() ?? "0");
if (ageUserValue > 18)
{
    Console.WriteLine($"Hello {nameUserValue}. You Your Age is {ageUserValue} and You are Mature");
}
else
{
    Console.WriteLine($"Hello {nameUserValue}. You Your Age is {ageUserValue} and You are Immature");
}
//Nusted If
//uses of if else, if else in between rapaidly is nusted if else if
if (ageUserValue > 18)
{
    Console.WriteLine($"Hello {nameUserValue}. You Your Age is {ageUserValue} and You are Mature");
    Console.Write("Do You Have ID Card?(Y/N): ");
    string optionValue = Console.ReadLine() ?? "N";
    optionValue = optionValue.ToUpper();
    if (optionValue == "Y")
    {
        Console.WriteLine("Good You are A Good Person.");
    }
    else
    {
        Console.WriteLine("Please Go And Get ID Card For You");
    }
}
else
{
    Console.WriteLine($"Hello {nameUserValue}. You Your Age is {ageUserValue} and You are Immature");
}
Console.ReadLine();
//Ternerry
//if we have to print a single line of code when the Condition is true or false we can use Termerry.
int randomValue = 100;
//         Variable         =   (Condition)        ? If the Condition is True This Message Will Apper: If Condition is False This Message Apper
string answerForRandomValue = (randomValue == 100) ? "The Value You Enter is True For the Condition" : "The Value is False For the Condition";
Console.WriteLine(answerForRandomValue);
Console.ReadLine();
//Switch Case
//it's Work as if else but we can Compare the Input Value Given by User
int valueForSwitch;
Console.Write("Enter A Number For Message(1-4): ");
valueForSwitch = Convert.ToInt32(Console.ReadLine());
switch (valueForSwitch)
{
    case 1:
        Console.WriteLine($"You Enter {valueForSwitch}. This Means You are in 1st Case");
        break;
    case 2:
        Console.WriteLine($"You Enter {valueForSwitch}. This Means You are in 2st Case");
        break;
    case 3:
        Console.WriteLine($"You Enter {valueForSwitch}. This Means You are in 3rd Case");
        break;
    case 4:
        Console.WriteLine($"You Enter {valueForSwitch}. This Means You are in 4th Case");
        break;
    default:
        Console.WriteLine("Invalid Number");
        break;
}
Console.ReadLine();