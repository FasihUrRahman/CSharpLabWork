//DataTypes
//Number Data Type | Value Type
    //Integer Data Type | 4 bytes in RAM
int numberInt = 30, maxValueInt = int.MaxValue, miniValueInt = int.MinValue;

Console.WriteLine("DataType Integer: " + numberInt);
Console.WriteLine("DataType Integer Maximum Value: " + maxValueInt);
Console.WriteLine("DataType Integer Minimum Value: " + miniValueInt);

    //Byte Data Type | 8-bit in RAM
byte numberByte = 30, maxValueByte = byte.MaxValue, miniValueByte = byte.MinValue;

Console.WriteLine("DataType Byte: " + numberByte);
Console.WriteLine("DataType Byte Maximum Value: " + maxValueByte);
Console.WriteLine("DataType Byte Minimum Value: " + miniValueByte);

    //Float Data Type | 4 bytes in RAM
float numberFloat = 30.0f, maxValueFloat = float.MaxValue, miniValueFloat = float.MinValue;

Console.WriteLine("DataType Float: " + numberFloat);
Console.WriteLine("DataType Float Maximum Value: " + maxValueFloat);
Console.WriteLine("DataType Float Minimum Value: " + miniValueFloat);

    //Double Data Type | 8 bytes in RAM
double numberDouble = 30, maxValueDouble = double.MaxValue, miniValueDouble = double.MinValue;

Console.WriteLine("DataType Double: " + numberDouble);
Console.WriteLine("DataType Double Maximum Value: " + maxValueDouble);
Console.WriteLine("DataType Double Minimum Value: " + miniValueDouble);

    //Short Data Type | 2 bytes in RAM
short numberShort = 30, maxValueShort = short.MaxValue, miniValueShort = short.MinValue;

Console.WriteLine("DataType Short: " + numberShort);
Console.WriteLine("DataType Short Maximum Value: " + maxValueShort);
Console.WriteLine("DataType Short Minimum Value: " + miniValueShort);

    //Long Data Type | 8 bytes in RAM
long numberLong = 30, maxValueLong = long.MaxValue, miniValueLong = long.MinValue;

Console.WriteLine("DataType Long: " + numberLong);
Console.WriteLine("DataType Long Maximum Value: " + maxValueLong);
Console.WriteLine("DataType Long Minimum Value: " + miniValueLong);

//Alphabatic Data Type | Referance Type
    //Character Data Type | 2 bytes
char pass = 'P';
Console.WriteLine(pass);

    //String Data Type | minimum 2 bytes for each Character init
string myName = "FasihUrRahman";
Console.WriteLine(myName);

    //Object Data Type | This will get any data Type
object userName = "FasihUrRahman";
object userAge = 25;
Console.WriteLine($"My Name is {userName} and My Age is {userAge}.");

    //Dynamic Data Type | This will get any data Type
dynamic userName1 = "FasihUrRahman";
dynamic userAge1 = 25;
Console.WriteLine($"My Name is {userName1} and My Age is {userAge1}.");

    //Var Data Type | This will get any data Type
var userName2 = "FasihUrRahman";
var userAge2 = 25;
Console.WriteLine($"My Name is {userName2} and My Age is {userAge2}.");

//Ways of Writing Strings
string fName = "Fasih";
string lName = "Ur Rahman";
Console.WriteLine("My Name is " + fName + " " + lName);
Console.WriteLine($"My Name is {fName} {lName}");

//Get First Char of string
string myString = "Hello";
Console.WriteLine(myString[0]);

//Get String Length
string txt = "Hello";
Console.WriteLine(txt.Length);

//Convert to Upper Case
string txt1 = "Hello World";
Console.WriteLine(txt1.ToUpper());