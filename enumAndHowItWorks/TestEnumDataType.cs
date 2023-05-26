namespace enumAndHowItWorks
{
    enum TestEnumDataType   //by default the DataType we have is INT
{
        FirstValue, SecondValue, ThirdValue, FourthValue, FifthValue
}
    enum TestEnumDataType1  : short //Telling enum to save these value in Which data type
    {
        FirstValue = 10, SecondValue = 100, ThirdValue = 200, FourthValue = 400, FifthValue = 199   //Assigning some Literal Values to Our Properties
    }
}
