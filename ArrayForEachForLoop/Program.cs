//Variables
int a = 0;
int[] ramdata = new int[10];
ramdata[0] = 10;
ramdata[1] = 11;
ramdata[2] = 12;
ramdata[3] = 13;
ramdata[4] = 14;
ramdata[5] = 15;
ramdata[6] = 16;
ramdata[7] = 17;
ramdata[8] = 18;
ramdata[9] = 19;
Console.WriteLine("This is int "+a);
a = 10;
Console.WriteLine("This is int " + a);

int b = 11;
int c = 12;
int d = 13;
Console.WriteLine("This is array "+ramdata[0]);
Console.WriteLine("This is array "+ramdata[1]);
Console.WriteLine("This is array "+ramdata[2]);
Console.WriteLine("This is array "+ramdata[3]);
Console.WriteLine(" ");
int num= 0;
for (int i =0; i < ramdata.Length; i++)
{
    Console.WriteLine("This is Array Value From For "+ramdata[i]);
    num = num + ramdata[i];
    Console.WriteLine(num);
}

Console.WriteLine(" ");
//foreach (datatype variablename in arrayname)
//{

//}
foreach (int item in ramdata)
{
    Console.WriteLine("This is Array Value From Foreach" +item);
}


//End
Console.ReadLine();