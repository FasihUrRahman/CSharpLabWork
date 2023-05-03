Console.WriteLine("Implicit Explicit Boxing Unboxing and General Data Types");  //Heading Title

//Type Casting
Console.WriteLine("Type Casting");
Console.WriteLine("\tImplicit");
//Type Casting is Conversing Data type of Numbers From one to other there are two types of Type Casting
//Implicit: Conversning Lower Data Type to Bigger Data Type is Called Implicit
byte firstNumber = 10;  //intilizing Value to Variable with byte Data Type
int copyOfFirstNumber = firstNumber;    //Implicit Byte to Int Data Type 
Console.WriteLine($"After Implicit The Value is {copyOfFirstNumber}");
//byte copyOfFirstNumberAsbyteAgain = copyOfFirstNumber;    This Will Gives Error As it's Conversing Bigger Data Type to Lower
//Example
int valueOne = 40;
float copyOfValueOne = valueOne;
Console.WriteLine($"After Implicit The Value is {copyOfValueOne}");
//2nd Example
float valueTwo = 30.35f;
double copyOfValueTwo = valueTwo;
Console.WriteLine($"After Implicit The Value is {copyOfValueTwo}");

//Explicit: Conversning Bigger Data Type to Lower Data Type is Called Explicit
Console.WriteLine("\tExplicit");
double valueOneForExplicit = 3000;  //intilizing Value to Variable with double Data Type
float copyOfValueOneForExplicit = (float)valueOneForExplicit;   //Explicit double to float Data Type
Console.WriteLine($"After Explicit The Value is {copyOfValueOneForExplicit}");

//Example
float valueTwoForExplicit = 500.43f;
int copyOfValueTwoForExplicit = (int)valueTwoForExplicit;
Console.WriteLine($"After Explicit The Value is {copyOfValueTwoForExplicit}");

//Conversion
int valueOneForConversionIntToString = 450;
string copyOfValueOneForConversionIntToString = Convert.ToString(valueOneForConversionIntToString);
Console.WriteLine("By Adding Variable in to Number it Concatinate Them As " + (copyOfValueOneForConversionIntToString + 3));  //To Check it's Convert in a string or still an Int Value
Console.WriteLine($"After Conversion The Value is {copyOfValueOneForConversionIntToString}");

//Assignment Example
int valueForFloatConversion = 40;
float copyOfValueForFloatConversion = Convert.ToSingle(valueForFloatConversion);
Console.WriteLine($"After Conversion The Value is {copyOfValueForFloatConversion}");

//Parse: Converting a String Value to Number Value we Use Parse
string valueForIntParse = "504";
int copyValueForIntParse = int.Parse(valueForIntParse);
Console.WriteLine($"To Check it's Convert in Int we Plus 10 in Variable and the Answer is {copyValueForIntParse} + 10 = {copyValueForIntParse + 10}");
Console.WriteLine($"After Parsing The Value is {copyValueForIntParse}");

//Boxing
//Converting Value Data Type To Referance Data Type is Called Boxing
dynamic valueOneDynamic = "Fasih Ur Rahman";
var valueOneVar = 25;
object valueOneObject = 5.9;
Console.WriteLine($"My Name is {valueOneDynamic}. My Age is {valueOneVar} and my Height is {valueOneObject}.");

//Unboxing
//Converting Referance Data Type To Value Data Type is Called Boxing
string copyOfValueOneDynamic = Convert.ToString(valueOneDynamic);
int copyOfValueOneVar = Convert.ToInt32(valueOneVar);
float copyOfValueOneObject = Convert.ToSingle(valueOneObject);
Console.WriteLine($"My Name is {copyOfValueOneDynamic}. My Age is {copyOfValueOneVar} and my Height is {copyOfValueOneObject}.");
Console.ReadKey();