

int kitsCount = int.Parse(Console.ReadLine() ?? "_");

for (int _ = 0; _ < kitsCount; _++)
{
    int attemptsCount = int.Parse(Console.ReadLine() ?? "_");

    var validLogins = new List<string>();
    for (int __ = 0; __ < attemptsCount; __++)
    {
        string attempt = Console.ReadLine() ?? "_";
        if (IsValid(attempt, validLogins))
        {
            Console.WriteLine("YES");
            validLogins.Add(attempt.ToLower());
        }
        else
        {
            Console.WriteLine("NO");
        }
    }

    Console.WriteLine();
}

static bool IsValid(string attempt, List<string> validLogins)
{
    if (    attempt.All(c => char.IsAscii(c) && (char.IsLetterOrDigit(c) || c == '_' || c == '-'))
        &&  attempt[0] != '-'
        &&  attempt.Length >= 2
        &&  attempt.Length <= 24
        &&  validLogins.Contains(attempt.ToLower()) == false)
    {
        return true;
    }
    return false;
}