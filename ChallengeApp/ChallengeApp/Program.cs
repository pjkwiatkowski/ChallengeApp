Console.Write("Wpisz liczbę i naciśnij ENTER: ");
var number = Console.ReadLine();

string numberInString = number.ToString();
char[] letters = numberInString.ToCharArray();

for (int i = 0; i < 10; i++)

{
    int count = 0;
    foreach (char letter in letters)
    {
        if (i == char.GetNumericValue(letter))
        {
            count++;
        }
    }
        Console.WriteLine(i + " => " + count);
} 