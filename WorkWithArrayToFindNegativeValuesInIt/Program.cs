//Find Negative Value in Array
Console.Write("Write Numbers of Values You Wanna Put: ");
int valueForArray = Convert.ToInt32(Console.ReadLine());

int[] values = new int[valueForArray];
for(int i = 0; i < values.Length; i++)
{
    Console.Write($"Enter Value Number {i+1}: ");
    values[i] = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
}
int a = 0;

foreach (int value in values)
{
    if (value < 0)
    {
        Console.WriteLine(value);
        a++;
    }
}
Console.WriteLine($"Negative values in array are {a}");
Console.ReadLine();