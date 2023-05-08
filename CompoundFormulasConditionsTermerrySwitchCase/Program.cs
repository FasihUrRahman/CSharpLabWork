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
//Termerry

//Switch Case