System.Console.WriteLine("Enter your name:");
string name = Console.ReadLine();
string greating = $"Hello, {name}";
System.Console.WriteLine(greating);

int ageOfKescha = 2;
System.Console.WriteLine("Enter your age:");
string ageAsString = Console.ReadLine();
System.Console.WriteLine("Converting...");
int age = Convert.ToInt32(ageAsString);
System.Console.WriteLine($"Succesfully converted {age}");
int yearsDifference = age - ageOfKescha;
System.Console.WriteLine($"you are older than Kescha to {yearsDifference}");