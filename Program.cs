int gradeTotal = 0;
Console.WriteLine("Please enter each grade one by one as a percentage:");
for (int i = 0; i < 6; i++)
{
    int grade = Console.Read();
    gradeTotal = gradeTotal + grade;
}
Console.WriteLine(gradeTotal);
int average = gradeTotal / 6;
switch (average)
{

    case >= 70:
        Console.WriteLine("1st");
        break;
    case >= 60:
        Console.WriteLine("2-1");
        break;
    case >= 50:
        Console.WriteLine("2-2");
        break;
    case >= 40:
        Console.WriteLine("Pass");
        break;
    default:
    Console.WriteLine("bugger");
    break;
}

Console.ReadKey();