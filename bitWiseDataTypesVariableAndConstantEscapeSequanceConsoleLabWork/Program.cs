//Starting Heading
Console.WriteLine("BitWise");
//Bitwise will gives us (and) and (or) answers from binary to decimal
Console.Write("16 | 10 OR Bitwise is = ");
Console.WriteLine(16 | 10); //OR Bitwise
//64  32  16  8  4  2  1  0
//         1  0  0  0  0  0     Toget 16 Machine active one bit that's 16
//         0  1  0  1  0  0     Toget 10 Machine active two bits that's 8 and 2
//--------------------------
//         1  1  0  1  0  0     Performed OR Operation on Both we get this answer
//                       27     By adding bit's Numbers(16+8+2+1) we get 27
Console.Write("16 & 10 AND Bitwise is = ");
Console.WriteLine(16 & 10); //AND Bitwise
//64  32  16  8  4  2  1  0
//         1  0  0  0  0  0     Toget 16 Machine active one bit that's 16
//         0  1  0  1  0  0     Toget 10 Machine active two bits that's 8 and 2
//--------------------------
//         0  0  0  0  0  0     Performed AND Operation on Both we get this answer
//                        0     because of zero bit active we'll get the answer as Zero
Console.WriteLine("Variables And Constants");
//Decleration and Initilization of a variable
int age = 25; //Data Type Integer
Console.WriteLine("My Age is " + age); //Concatination with string
//Decleration of a variable
int price;  //Data Type Integer
//Initilization of a variable
price = 100;
Console.WriteLine("Todays Soap Price is " + price);
Console.ReadKey();
