Console.WriteLine("Proszę, wprowadż swój wiek");

int a = Int32.Parse(Console.ReadLine());

if (a > 20)
{
    Console.WriteLine("Gratulacje, możesz ubiegać się o stanowisko Posła RP");

}


if (a > 29)
{
    Console.WriteLine("Gratulacje, możesz ubiegać się o stanowisko Senatora RP");

}

if (a > 34)
{
    Console.WriteLine("Gratulacje, możesz ubiegać się o stanowisko Prezydenta RP");
}
