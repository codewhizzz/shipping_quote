// See https://aka.ms/new-console-template for more information
// Welcome message
Console.WriteLine("Welcome to Package Express. Please follow the instructions below");

// Ask for the package weight and convert the input from string to integer
Console.Write("Please add the package weight: ");
int weight = Convert.ToInt32(Console.ReadLine());

// Check if the weight exceeds the shipping limit (50 units)
if (weight > 50)
{
    // If it does, display a message and continue (this won't stop the program)
    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day");
}

// Ask for the package width and convert input to integer
Console.Write("Please add the package width: ");
int width = Convert.ToInt32(Console.ReadLine());

// Ask for the package height and convert input to integer
Console.Write("Please add the package height: ");
int height = Convert.ToInt32(Console.ReadLine());

// Ask for the package length and convert input to integer
Console.Write("Please add the package length: ");
int length = Convert.ToInt32(Console.ReadLine());

// Calculate the total size of the package (sum of dimensions)
int totalDimension = width + height + length;

// Check if the total dimensions exceed the allowed limit (50 units)
if (totalDimension > 50)
{
    // If they do, display an error message
    Console.WriteLine("Package too big to be shipped via Package Express.");
}

// Calculate the shipping quote using the formula: (height × width × length × weight) ÷ 100
// The `100f` ensures floating point division instead of integer division
float quote = height * width * length * weight / 100f;

// Display the calculated quote, formatted to 2 decimal places (e.g., $45.00)
Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
