//Operators
//Arthmatic Operators
Console.WriteLine("10 + 12 = "+ (10+12) + " Here '+' is an Arthmatic Opperator");    //Plus
Console.WriteLine("10 - 12 = "+ (10-12) + " Here '-' is an Arthmatic Opperator");    //Minus
Console.WriteLine("10 x 12 = "+ (10*12) + " Here '*' is an Arthmatic Opperator");    //Multiply
Console.WriteLine("10 / 12 = "+ (10/12) + " Here '/' is an Arthmatic Opperator");    //Divid
Console.WriteLine("10 % 12 = "+ (10%12) + " Here '%' is an Arthmatic Opperator");    //Modulus(Remander)
//Logical Operators
Console.WriteLine("5<7 && 8<10 = " + (5<7 && 8<10) + "Here '&&' is a Logical Operator"); //AND Operator
Console.WriteLine("5<7 || 8>10 = " + (5<7 || 8>10) + "Here '||' is a Logical Operator"); //OR Operator
Console.WriteLine("5<7 || !(8>10) = " + (5<7 || !(8>10)) + "Here '!' is a Logical Operator"); //NOT Operator
//Comparative Operators
Console.WriteLine("10 > 20 is " + (10 > 20) + "Here '>' is a Logical Operator");   //Greater Then
Console.WriteLine("10 < 20 is " + (10 < 20) + "Here '<' is a Logical Operator");   //Smaller Then
Console.WriteLine("10 == 20 is " + (10 == 20) + "Here '==' is a Logical Operator");   //Equal's To
Console.WriteLine("!(10 == 20) is " + !(10 == 20) + "Here '!' is a Logical Operator");   //Not

//Interpolation
string name = "Fasih Ur Rahman";
int age = 25;
Console.WriteLine($"My Name is {name} and my age is {age}");


//Program
float investmentValue, investmentYears, interestRate, outputValue;

string? inputValue;
Console.Write("Enter Investment Amount: ");
inputValue = Console.ReadLine();    //String Value As Input
investmentValue = Convert.ToSingle(inputValue); //Convert in Float

Console.Write("Enter Investment Year: ");
inputValue = Console.ReadLine();    //String Value As Input
investmentYears = Convert.ToSingle(inputValue); //Convert in Float


interestRate = 0.1f;
outputValue =  (investmentValue + (investmentValue*investmentYears*interestRate));

Console.WriteLine($"Your Total Amout After Profit is {outputValue} on the Investment of {investmentValue} for This {investmentYears} Much Years on the Interest Rate of {interestRate}%");
Console.ReadLine();

//Example For Student Marks
int english, urdu, maths, science, totalMarks;
float percentage;
string? inputValueForMarks;
//Marks For English
Console.Write("Enter Number For English(1-100): ");
inputValueForMarks =  Console.ReadLine();
english = Convert.ToInt32(inputValueForMarks); //Convert in INT

//Marks For Urdu
Console.Write("Enter Number For Urdu(1-100): ");
inputValueForMarks = Console.ReadLine();
urdu = Convert.ToInt32(inputValueForMarks); //Convert in INT

//Marks For Maths
Console.Write("Enter Number For Math(1-100): ");
inputValueForMarks = Console.ReadLine();
maths = Convert.ToInt32(inputValueForMarks); //Convert in INT

//Marks For Science
Console.Write("Enter Number For Science(1-100): ");
inputValueForMarks = Console.ReadLine();
science = Convert.ToInt32(inputValueForMarks); //Convert in INT

totalMarks = english+urdu+maths+science;
percentage = (totalMarks) / 4;
Console.Write($"You Get Total Marks {totalMarks} Out of 400. The Percentage is {percentage}");
Console.ReadLine();
