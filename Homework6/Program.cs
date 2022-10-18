// Method 1: Show Character - Accepts string input, Integer position. Returns char.
static char ShowCharacter(string input, int pos)
{
    // Check if position is greater than 0.
    if (pos > 0)
    {
        pos--;
        // Try to get the character at specified position if not, throw an exception
        try
        {
            return input[pos];
        }
        // No character at position given
        catch
        {
            throw new ArgumentOutOfRangeException("There is no character at this position");
        }
    }
    // Position is in valid
    else
    {
        throw new ArgumentOutOfRangeException($"{pos} is out of range");
    }
}

// Method 2: Retail Price - Accepts decimal wholesale cost, Decimal markup percentage. Returns decimal which is the retail price.
static decimal CalculateRetail(decimal wholesale, decimal markup)
{
    // Add wholesale to the markup
    decimal result = (wholesale + ((markup/100) * wholesale));
    // Return the result rounded to 2 decimal places
    return Math.Round(result, 2);
}


// Method 3: Temperature Table - Accepts double in Fahrenheit. Returns in Celsius.
static double Celsius(double temp)
{
    // Convert temp (F) to temp (C)
    double result = (temp - 32) * 5 / 9;
    // Return the result rounded to 4 decimal places
    return Math.Round(result, 4);
}


// Method 4: Prime Numbers - Accepts integer to check if prime. Returns boolean if prime.
// Logic from https://en.wikipedia.org/wiki/Primality_test
// https://stackoverflow.com/questions/15743192/check-if-number-is-prime-number
static bool IsPrime(int input)
{
    if (input == 2 || input == 3) return true; // 2 and 3 are always prime
    if (input <= 1 || input % 2 == 0) return false; // prime numbers cannot be 1, 0, or negative numbers, mod 2 = 0, or mod 3 = 0.
    var boundary = (int)Math.Floor(Math.Sqrt(input));

    for (int i = 3; i <= boundary; i += 2)
        if (input % i == 0)
            return false;

    return true;
}

// Run and output all of the methods

////////////////
/// Method 1 ///
////////////////

Console.WriteLine("Method 1: ShowCharacter");
Console.Write("Input a string: ");
string showCharacterStringInput = Console.ReadLine();

Console.Write("Input an integer to get char at position from previous string: ");
int showCharacterIntInput = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Method 1 Output: {ShowCharacter(showCharacterStringInput, showCharacterIntInput)}");

////////////////
/// Method 2 ///
////////////////

Console.WriteLine("\nMethod 2: CalculateRetail");
Console.Write("Input wholesale cost: ");
decimal calculateRetailWholesale = Convert.ToDecimal(Console.ReadLine());

Console.Write("Input markup without %: ");
decimal calculateRetailMarkup = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"Method 2 Output: {CalculateRetail(calculateRetailWholesale, calculateRetailMarkup)}");

////////////////
/// Method 3 ///
////////////////

Console.WriteLine("\nMethod 3: Celsius 80-100");
// Define list for storing variables to show later
// https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-7.0
List<double> celsiusOutput = new List<double>();
foreach (var c in Enumerable.Range(80, 100))
{
    // Add output to list
    celsiusOutput.Add(Celsius(c));
}
Console.Write($"Method 3 Output: ");
// https://stackoverflow.com/questions/52927/console-writeline-and-generic-list
celsiusOutput.ForEach(i => Console.Write($"{i}\t"));

////////////////
/// Method 4 ///
////////////////

Console.WriteLine("\n\nMethod 4: IsPrime");
Console.Write("Input an integer to check for prime: ");
int testForPrime = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Method 4 Output: {IsPrime(testForPrime)}");