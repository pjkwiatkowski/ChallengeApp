var name = "Marek";
bool male = true;
var age = 23;
var eyesColor = "blue";

if (male == false && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if ( name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (male && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else if (male == false && age >= 30)
{
    Console.WriteLine("Kobieta minimum 30 lat");
}
else if (male == false && eyesColor == "blue")
{
    Console.WriteLine("Kobieta o niebieskich oczach");
}
else if (male && age >= 20 && age <= 25)
{
    Console.WriteLine("Mężczyzna w wieku 20-25 lat");
}
else
{
    Console.WriteLine("Nie zweryfikowano");
}