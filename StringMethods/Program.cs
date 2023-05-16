//String Methods
//As we Read Methods For Char It's Same For String.
string msg;
string[] msgResult = null;
Console.Write("Enter Message Here: ");
msg = Console.ReadLine();

Console.WriteLine($"Characters in The Strings Is/Are {msg.Length}");    //Check Length of String

Console.WriteLine($"This Will Replace a to F in String {msg.Replace("a", "F")}");   //To Replace Any Character Value From String

msgResult = msg.Split(' '); //This Will Split String in parts according to given Value to it
Console.WriteLine(msgResult[0]);


char trimToRemove = ' ';
string newMsg = msg.Trim(trimToRemove);   //Remove Special Characters From String's Start or end
Console.WriteLine(newMsg.Length);
Console.WriteLine($"{newMsg}");

    int a = String.CompareOrdinal(msg, "Fasih");    //Compare String With the String We Entered
Console.WriteLine($"If It's Zero Then The Value We Entered is Equals To the Value We Stored in Data Base = {a}");

    a = msg.CompareTo("Fasih"); //Another Way to Compare Strings
Console.WriteLine(a);   //This Will Return -1, 0, 1 Depends on Query if the values are not equals to the value we mentioned it will return -1
                        //If the Value is equals to the Value to Mentioned It Will Return 0
                        //if the Value is equals and having some more information then the value we mentioned it will return 1

int index = msg.IndexOf("a"); //This will returns index Number For the Given Number
Console.WriteLine(index);

Console.ReadLine();