﻿//Enum
//Enum is a keyword that used to create own Custom DataType. it can only save the values that is in value type as enum is value type.
using enumAndHowItWorks;    //Calling File That we Create
Console.WriteLine("This is How To use Enum");
TestEnumDataType tedt = TestEnumDataType.FirstValue;    //Getting Value from enum
TestEnumDataType tedt1 = TestEnumDataType.SecondValue;  //Getting Value from enum
int i = (int)tedt1; //Cast the Value as enum is value type and Store Int Data by it-self
Console.WriteLine(tedt);
Console.WriteLine(tedt1);
Console.WriteLine(i);
Console.ReadLine();