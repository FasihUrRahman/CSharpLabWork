//Arthmatic Operators
Console.Write("10 + 9 = ");
Console.WriteLine(10 + 9); //Plus Operator
Console.Write("10 - 9 = ");
Console.WriteLine(10 - 9); //Minus Operator
Console.Write("10 x 9 = ");
Console.WriteLine(10 * 9); //Multiply Operator
Console.Write("10 / 9 = ");
Console.WriteLine(10 / 9); //Devide Operator
Console.Write("10 % 9 = ");
Console.WriteLine(10 % 9); //Modules Operator
Console.Write("Hit Enter Key For Next Message.....");
Console.ReadLine();
//Comparison Operators
//This will Give's Answer in Boolean
Console.WriteLine(10 > 9); //Means: 10 Greater Than 9
Console.WriteLine(10 < 9); //Means: 10 Smaller Than 9
Console.WriteLine(10 == 9); //Means: 10 Equals To 9
Console.WriteLine(10 >= 9); //Means: 10 Greater Than Or Equal To 9
Console.WriteLine(10 <= 9); //Means: 10 Smaller Than Or Equal To 9
Console.WriteLine(10 != 9); //Means: 10 Not Equal To 9
Console.Write("Hit Enter Key For Next Message.....");
Console.ReadLine();
//Logical Operators
//These Operators use to build logics. This Will Give's Answer in Boolean.
Console.WriteLine((10 > 9) && (15 < 20)); //Means: 10 Greater Than 9 AND 15 Smaller Than 20. Which is True.
Console.WriteLine((10 > 9) && (15 > 20)); //Means: 10 Greater Than 9 AND 15 Greater Than 20. Which is Fales.
Console.WriteLine((10 > 9) || (15 < 20)); //Means: 10 Greater Than 9 OR 15 Smaller Than 20. Which is True.
                                          //Because Both Are True.
Console.WriteLine((10 > 9) || (15 > 20)); //Means: 10 Greater Than 9 OR 15 Smaller Than 20. Which is True.
                                          //Because One of Them Are True.
Console.WriteLine((10 < 9) || (15 < 20) && (25 < 10) || !(60 > 40)); //Means: 10 Smaller Than 9 OR 15 Smaller
                                                                     //Then 20 AND 25 Smaller Than 10 OR 60
                                                                     //NOT Greater Than 40. Which is True.
                                                                     //Because One of them is True.
Console.Write("Hit Enter Key For Next Message.....");
Console.ReadLine();
Console.WriteLine("Thanks For Joining Me. Good Bye");
Console.WriteLine("Hit Any Key to Exit.");
Console.ReadKey();