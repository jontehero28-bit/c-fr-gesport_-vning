
Console.WriteLine("Välkommen till universums dummaste frågesport!");
Console.WriteLine("Vad heter du då?");

string name;
int points = 0;

name = Console.ReadLine();

Console.WriteLine($"Välkommen, {name} hoppas du vinner!");
Console.WriteLine("Du ska skriva bokstaven före svar alternativet");
Console.WriteLine("Fråga nummer 1: Vad heter Sverige?");
Console.WriteLine("A)https://www.youtube.com/watch?v=dQw4w9WgXcQ B)Schweden C)Sweden D)Sverige");
string svar1 = Console.ReadLine();
if (svar1 == "D")
{
    points++;
    Console.WriteLine($"RÄTT, bra jobbat {name}. Du får 1 poäng för det");

}
else if (svar1 == "C")
{
    Console.WriteLine("Swedish mf, do you speak it?");
}
else
{
    Console.WriteLine("FEL");
}
Console.ReadLine();
//------------------------------------------------------------------------------

Console.WriteLine("Fråga nummer 2: 2x2?");
Console.WriteLine("A)4 B)8 C)2");
string svar2 = Console.ReadLine();
if (svar2 == "A")
{
    points++;
    Console.WriteLine($"RÄTT, bra jobbat {name}. Du får 1 poäng för det");
}
else
{
    Console.WriteLine("FEL");
}

Console.ReadLine();
//------------------------------------------------------------------------------

Console.WriteLine("Fråga nummer 3:");
string svar3 = Console.ReadLine();


Console.ReadLine();



