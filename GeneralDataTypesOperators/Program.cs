//Global Data Types
//Object
//Object is Class Of All Classes and can store data with no data type limit
//But the issue with Object is every time we get Data we have to unbox it first
object valueOneOfObject = "Fasih Ur Rahman"; // String Type data
object valueTwoOfObject = 90; //Int Type Data
object valueThreeOfObject = 90.47f; //Float Type Data
Console.WriteLine($"Here Object Store String Type Data As '{valueOneOfObject}' and Stored Int Type Data As '{valueTwoOfObject}' and Also a Flot Type Data Too As '{valueThreeOfObject}'");
//When We try to add Int Value with Int Type Object it shows error
int valueOneOfInt = 10;
//Console.WriteLine(valueTwoOfObject + valueOneOfInt); //<-It Shows Error When We Run it Without UnBoxing
//To Perform Mathmatical Operations from Object We Have to Unbox Object Before Performing it
//Unboxing of Object
int unboxingOfValueTwoOfObject = Convert.ToInt16(valueTwoOfObject);
Console.WriteLine(unboxingOfValueTwoOfObject + valueOneOfInt);  //this Shows 100 as Answer

//Var
//Var is General Data Type but it's Strong and Intelegent Data type Too. The Issue With Var is it's Local Data Type
//var can't be declare and later on initilize
//It have to be delare and initilize at the same time
var valueOneOfVar = "Fasih Ur Rahman";
var valueTwoOfVar = 90;
var valueThreeOfVar = 90.47;
Console.WriteLine($"Here Var Store String Type Data As '{valueOneOfVar}' and Stored Int Type Data As '{valueTwoOfVar}' and Also a Flot Type Data Too As '{valueThreeOfVar}'");
//Var is This Much Mature to Under Stand What Data Type it is And What actions can be performed
//Example Math Problem Solving
Console.WriteLine(valueTwoOfVar + valueThreeOfVar); // it Converts Int(90) to a Float as our Bigger Data Type Float is Already here and then Plus both and Shows answer

//Dynamic
//Dynamic is Also a General Data Type and Acts as Object but it's better Version of Object. It's Weakly Data Type But Intelegent and it's Scope is Global as Object
//Dynamic Can Declare and Later on Initilize
dynamic valueOneOfDynamic;
valueOneOfDynamic = 100;
dynamic valueTwoOfDynmaic = "Fasih Ur Rahman";
Console.WriteLine($"Here Var Store String Type Data As '{valueTwoOfDynmaic}' and Stored Int Type Data As '{valueOneOfDynamic}'.");
//Dynamic is This Much Mature to Under Stand What Data Type it is And What actions can be performed
//Example Math Problem Solving
Console.WriteLine(valueOneOfDynamic + 100); //Show's Answer as 200 Because it Sence The Value and Then Solve it as Int

//Operators
//Unri Operators
//Prefix Unri Operators
int valueOneOfPrefixOperator = 10;
int valueTwoOfPrefixOperator = ++valueOneOfPrefixOperator; //What This Will Do is Explain Below
                                                           //valueOneOfPrefixOperator = valueOneOfPrefixOperator + 1;
                                                           //valueTwoOfPrefixOperator = valueOneOfPrefixOperator;
Console.WriteLine($"Value Of valueTwoOfPrefixOperator = {valueTwoOfPrefixOperator}"); //This Will Shows 11 as Result
Console.WriteLine($"Value Of valueOneOfPrefixOperator = {valueOneOfPrefixOperator}"); //This Will Shows 11 as Result

//Postfix Unri Operators
int valueOneOfPostfixOperator = 10;
int valueTwoOfPostfixOperator = valueOneOfPostfixOperator++; //What This Will Do is Explain Below
                                                             //valueTwoOfPostfixOperator = valueOneOfPostfixOperator;
                                                             //valueOneOfPostfixOperator = valueOneOfPostfixOperator + 1;
Console.WriteLine($"Value Of valueTwoOfPostfixOperator = {valueTwoOfPostfixOperator}");   //This Will Print 10 As Result
Console.WriteLine($"Value Of valueOneOfPostfixOperator = {valueOneOfPostfixOperator}");   //This Will Print 11 As Result of Our First Variable with Increment

Console.ReadLine();