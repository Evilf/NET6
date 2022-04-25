string numbers = "";
int result = 0;
string input = "";

do
{
    Console.WriteLine("Zadejte celé číslo nebo Q pro konec");
    input = Console.ReadLine();

    if (numbers == "" && input.All(char.IsDigit))
        numbers += input;
    else if (input.All(char.IsDigit))
        numbers += ", " + input;

    if (input.All(char.IsDigit))
        result += int.Parse(input);
}
while (input != "q" && input != "Q");

if (numbers != "")
    Console.WriteLine($"Součet čísel: {numbers} je {result}");
else
    Console.WriteLine("Nebyla zadána žádná čísla");
