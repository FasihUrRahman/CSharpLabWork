//Enum
//Enum is a keyword that used to create own Custom DataType. it can only save the values that is in value type as enum is value type.
using enumAndHowItWorks;    //Calling File That we Create
Console.WriteLine("This is How To use Enum");
TestEnumDataType tedt = TestEnumDataType.FirstValue;    //Getting Value from enum
TestEnumDataType tedt1 = TestEnumDataType.SecondValue;  //Getting Value from enum
int i = (int)tedt1; //Cast the Value as enum is value type and Store Int Data by it-self
Console.WriteLine(tedt);
Console.WriteLine(tedt1);
Console.WriteLine(i);
TestEnumDataType1 tedt11 = TestEnumDataType1.FirstValue;
TestEnumDataType1 tedt12 = TestEnumDataType1.SecondValue;
Console.WriteLine(tedt11);
Console.WriteLine(tedt12);
short i1 = (short)tedt11;
Console.WriteLine(i1);
Console.ReadLine();