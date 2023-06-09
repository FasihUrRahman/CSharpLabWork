﻿//Starting Heading
//BitWise
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

//Variables And Constants
Console.WriteLine("Variables And Constants");
Console.WriteLine("Variables");
//Variables
//Decleration and Initilization of a variable
int age = 25; //Data Type Integer
Console.WriteLine("My Age is " + age); //Concatination with string
//Decleration of a variable
int price;  //Data Type Integer
//Initilization of a variable
price = 100;
Console.WriteLine("Todays Soap Price is " + price); //Concatination with string
float marksPercentage;
marksPercentage = 60.65F; //Add Float Value with Capital F in the end of number
Console.WriteLine("I obtained " + marksPercentage + "% out of 100%");
double mapCoordinatX , mapCoordinatY; //Decleration of Two Variables
mapCoordinatX = 0.498721356423; //double add more numbers then float after dot
mapCoordinatY = 0.482973237234;
Console.WriteLine("My Current Location's Coordinates are " + mapCoordinatX + "X " + mapCoordinatY + "Y");
char firstLaterOfMyName;
firstLaterOfMyName = 'F'; //Char can Store only one charater
Console.WriteLine("My Name is Fasih and the First Word of my Name is " + firstLaterOfMyName);
string collegeName = "The Tips"; //string Can Store as Many Charaters as We Want
Console.WriteLine("My College Name is " + collegeName);
mapCoordinatX = 0.742937423683; //Variables can be change at any time according to requirement
mapCoordinatY = 0.742856294239;
Console.WriteLine("Now My New Current Location's Coordinates are " + mapCoordinatX + "X " + mapCoordinatY + "Y");
bool workDone = true; //bool is the short form of Boolean and it's Used for getting the value as 1 or 0 | True or False
Console.WriteLine(workDone);

//Constant
Console.WriteLine("Constants");
const string companyName = "AgencyPrism"; //const is short form of Constant and can not be changed after once it's value done
Console.WriteLine("My Company's Name is " + companyName + ". In " + companyName + " We all work together.");

//A Small Working Discount Function
Console.WriteLine("Application of Variable and Constant with Operators");
const int totalDiscountInPercentage = 30; //constant initilization
int productPrice, discountPrice, totalPriceAfterDiscount; //variable initilization
productPrice = 200;
discountPrice = (productPrice * totalDiscountInPercentage) / 100; //formula for discount price
totalPriceAfterDiscount = productPrice - discountPrice; //Actual Price after Discount
Console.WriteLine("You Purchase the Product at Cost Rs." + productPrice + ". On this product you'll get the Discount of " + totalDiscountInPercentage + "%. Your Current " +
    "Price that you have to pay after Discount is Rs." + totalPriceAfterDiscount);
Console.ReadKey();
