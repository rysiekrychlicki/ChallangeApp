var name = "Ewa";
var sex = "K";
var age = 33;

if (sex == "K" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (sex != "K" && age < 18)
{
    Console.WriteLine("Niepełnoletni Męzczyzna");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}