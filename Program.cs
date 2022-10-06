char choice;
do{
int x, y, z, pn = 0;
Console.WriteLine("Enter 3 real numbers pls: ");
x = Convert.ToInt32(Console.ReadLine());
y = Convert.ToInt32(Console.ReadLine());
z = Convert.ToInt32(Console.ReadLine());
if (x < 0) { pn = pn + 1; }
if (y < 0) { pn = pn + 1; }
if (z < 0) { pn = pn + 1; }
Console.WriteLine(pn);
if (pn == 0 || pn == 2) { Console.WriteLine("Your number is postitive"); }
else if (pn == 1 || pn == 3) { Console.WriteLine("Your number is negative"); }
Console.WriteLine("would you like to repeat the program? (press n to end): ");
choice = Convert.ToChar(Console.ReadLine());
}
while(choice != 'n');