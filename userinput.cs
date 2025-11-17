// Prompt for name and age, with validation
Console.Write("What's your name? ");
string? name = Console.ReadLine();
if (string.IsNullOrWhiteSpace(name))
{
	name = "Guest"; // fallback
}

Console.Write("What's your age? ");
int age = 0;
string? ageInput = Console.ReadLine();
while (!int.TryParse(ageInput, out age))
{
	if (ageInput == null)
	{
		// input stream closed, keep default age
		break;
	}
	Console.Write("Please enter a valid whole number for age: ");
	ageInput = Console.ReadLine();
}

Console.WriteLine("Hello, " + name);
Console.WriteLine("You are " + age + " years old");