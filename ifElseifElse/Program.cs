Console.Write("Enter Hour to Get Message(1-24):"); //User Message For Input
int timeValue = Convert.ToInt32(Console.ReadLine()); //Get Value form User

if(timeValue <= 11 && timeValue > 6) //Morning Condition
{
    Console.WriteLine("Good Morning");  //Message For Morning Condition
}
else if(timeValue <= 15 && timeValue > 11)  //Afternoon Condition
{
    Console.WriteLine("Good Afternoon");    //Message For Afternoon Condition
}
else if(timeValue <= 20 &&  timeValue > 15) //Evening Condition
{
    Console.WriteLine("Good Evening");  //Message For Eveing 
}
else if((timeValue <= 24 &&  timeValue > 20) || (timeValue <= 6))   //Night Condition
{
    Console.WriteLine("Good Night");    //Night Message
}
else
{
    Console.WriteLine("Invalid Value"); //For Any Wrong Query
}