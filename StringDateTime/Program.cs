//String Methods
string name = "Fasih, Ali, Muzamil, Mudassar, Ahsan, Usman, Zafar", name2 = "Fasih";
string[] names = name.Split(", ");  //Split String Data
Array.Sort(names);  //Sort Array
int index = 0;
//Display From Loop
foreach (string item in names)
{
    Console.WriteLine($"{++index} Name in List are {item}");
}
//To Check Condition For The String
Console.WriteLine(name.Equals(name2));
Console.WriteLine(names[2].Equals(name2));

//Variables
string? inputValue1, inputValue2;
//Array
string[] inputValue;
int inputIndex = 0;
//A Small Project(Getting Input From User and Check The Index Number of the Value)
Console.WriteLine("Enter Your Paragraph Here");
Console.Write(">>");
inputValue1 = Console.ReadLine();

Console.WriteLine("Enter Your Word Here");
Console.Write(">>");
inputValue2 = Console.ReadLine();

if (inputValue1 != "")
{
    inputValue = inputValue1.Split(" ");
    for (int i = 0; i<inputValue.Length; i++)
    {
        if (inputValue[i].ToLower() == inputValue2.ToLower())
        {
            inputIndex = i;
            Console.WriteLine($"Your Word is At {inputIndex}");
        }
    }
}
Console.ReadLine();