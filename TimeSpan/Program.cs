//Time Span
//TimeSpan is Uses for performing mathematical operations on Time
Console.Write("Enter Your Date Of Birth (YYYY MM DD): ");
DateTime dt1 = DateTime.Today;
DateTime dt2 = Convert.ToDateTime(Console.ReadLine());
TimeSpan ageDays = dt1.Subtract(dt2);
int ageYears = (int)(ageDays.Days/365.25);
int ageMonths = (int)(ageDays.Days / 365.25) * 12;
int ageWeeks = (int)(ageMonths * 4.34524);
Console.WriteLine($"{ageYears} = Years, {ageMonths} = Months, {ageWeeks} = Weeks, {ageDays.Days} = Days");
Console.ReadLine();