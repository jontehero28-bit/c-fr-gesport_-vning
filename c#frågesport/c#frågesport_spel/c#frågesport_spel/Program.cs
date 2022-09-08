
Console.WriteLine("Välkommen till universums dummaste frågesport!");
Console.WriteLine("Vad heter du då?");

string name;
int points = 0;

name = Console.ReadLine();

Console.WriteLine($"Välkommen, {name} hoppas du vinner!");
Console.WriteLine("För att ange din svar du ska skriva in bokstaven som kommer före alternativet.");
Console.WriteLine("Fråga nummer 1: Vad heter Sverige?");
Console.WriteLine("A)https://www.youtube.com/watch?v=dQw4w9WgXcQ B)Schweden C)Sweden D)Sverige");
string svar1 = Console.ReadLine();
svar1 = svar1.ToLower();

if (svar1 == "d")
{
    points++;
    Console.WriteLine($"RÄTT, bra jobbat {name}. Du får 1 poäng för det");

}
else
{
    Console.WriteLine("Swedish mf, do you speak it?");
    Console.WriteLine($"FEL. tryck enter för att gå till nästa fråga {name}");
}
Console.ReadLine();

//------------------------------------------------------------------------------

Console.WriteLine("Fråga nummer 2: 2x2?");
Console.WriteLine("A)4 B)8 C)2");
string svar2 = Console.ReadLine();
svar2 = svar2.ToLower();

if (svar2 == "a")
{
    points++;
    Console.WriteLine($"RÄTT, bra jobbat {name}. Du får 1 poäng för det");
}
else
{
    Console.WriteLine($"FEL. tryck enter för att gå till nästa fråga {name}");
}

Console.ReadLine();

//------------------------------------------------------------------------------

Console.WriteLine("Fråga nummer 3: Kan tjejer bajsa?");
Console.WriteLine("A)Ja? Nej? idk, har aldrig pratat med en B)Nej, allt skit går i deras personlighet C)lol women, gay");
string svar3 = Console.ReadLine();
svar3 = svar3.ToLower();

if (svar3 == "b")
{
    points++;
    Console.WriteLine($"RÄTT, bra jobbat {name}. Du får 1 poäng för det");
}
else
{
    Console.WriteLine($"FEL. tryck enter för att gå till nästa fråga {name}");
}

Console.ReadLine();

//-------------------------------------------------------------------------------

Console.WriteLine("Fråga nummer 4: Varför är svart är så mörk?");
Console.WriteLine("A)Spogebob B)För att ljus strålar kommer inte in i ögat och du kan inte se något C)I cant hear you its too dark in here");
string svar4 = Console.ReadLine();
svar4 = svar4.ToLower();

if (svar4 == "c")
{
    points++;
    Console.WriteLine($"RÄTT, bra jobbat {name}. Du får 1 poäng för det");
}
else if (svar4 == "a")
{
    points++;
    Console.WriteLine($"RÄTT, bra jobbat {name}. Du får 1 poäng för det");
}
else
{
    Console.WriteLine($"FEL. tryck enter för att gå till nästa fråga {name}");
}

Console.ReadLine();

//--------------------------------------------------------------------------------------------

Console.WriteLine("Fråga nummer 5: Vad hände 1989 4 juni på himmelska fridens torg?");
Console.WriteLine("A)något B)inget C)Taiwan är en del av Kina D)Tusentals kinesika studenter blev skjutna");
string svar5 = Console.ReadLine();
svar5 = svar5.ToLower();

if (svar5 == "b")
{
    points++;
    Console.WriteLine($"RÄTT, bra jobbat {name}. Du får 1 poäng för det");
}
else if (svar5 == "c")
{
    points++;
    Console.WriteLine($"RÄTT, bra jobbat {name}. Du får 1 poäng för det. Det var sista fråga! Tryck Enter för att se resultat.");
}
else
{
    Console.WriteLine($"FEL. tryck enter för att få se resultat {name}");
}

Console.ReadLine();

//-----------------------------------------------------------------------------------------------------------

Console.WriteLine($"Wohoo! Du fick {points} poäng! Bra jobbat!!!");

if (points == 0)
{
    Console.WriteLine("Du hade alla fel bre");
}
else if (points < 3)
{
    Console.WriteLine("Du hade några rätt bre");
}
else
{
    Console.WriteLine("Du hade alla rätt bre!!!");
}

Console.ReadLine();

//--------------------------------------------------------------------------------------------------------------------

Console.ReadLine();