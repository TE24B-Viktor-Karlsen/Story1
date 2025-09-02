using System.Xml.Serialization;

Console.WriteLine("Du har vaknat, tidigt på morgonen. Ett zombie virus har sträckt sig över hela världen. Ingen är hemma. Du går upp från sängen och tittar ut genom fönstret där du ser hela Stockholm i bränder. Vad Gör du? Ring eller kollar min säkerhet");
String val = Console.ReadLine();

if (val == "Ring")
{
    Console.WriteLine("Ingen koppling, fel val");
}
else if (val == "kollar min säkerhet")
{
    Console.WriteLine("Rätt val");
}



Console.WriteLine("Det brinner i hela botten våningen och du hör zombies våningen under Vad gör du? Hoppar ut genom fönstret eller springer upp till tak terassen");
String val1 = Console.ReadLine();

if (val1 == "Hoppar ut genom fönstret")
{
    Console.WriteLine("Du dog, fel val");
}
else if (val1 == "springer upp till tak terassen")
{
    Console.WriteLine("Rätt val");
}



Console.WriteLine("Du går ut ur lägenheten och springer upp för trapporna. Du ser röken långsamt forma sig upp genom lägenheten och hör zombiserna vråla sig närmare. Du kom upp på taket precis innan en annan frisk människa och du stängde dörren innan han passerade dörren. En helikopter flyger ovanför och försöker rädda människor, men de ser dig inte. Vad gör du? Fortsätter blockera dörren och vänta tills helikoptern ser dig eller öppna dörren");
String val2 = Console.ReadLine();

if (val2 == "Fortsätter blockera dörren och vänta tills kelikoptern landar")
{
    Console.WriteLine("Efter ett tag / Helikoptern såg dig inte och dina krafter dog slut, zombiserna slät upp dörren och du blev smittad. Fel val");
}
else if (val2 == "öppna dörren")
{
    Console.WriteLine("Du öppnade dörren innan zomiserna tog tag i människan. Ni hjälps åt att blockera dörren dessutom har människan en flare. Ni signalerar fram helikoptern och tar er till säkerhet. Rätt val");
}

Console.ReadLine();













// bool isAlive = true;
// isAlive = 12 > 10;
// isAlive = 6 < 10;
// isAlive = 6 != 10;
// isAlive = 10 == 10;




// string name = Console.ReadLine();

// if (name == "Viktor")
// {
//     Console.WriteLine("Välkommen!");
// }
// else if (name == "Gustav")
// {
//     Console.WriteLine("Lite Välkommen!");
// }
// else
// {
//      Console.WriteLine("Du lucktar dachri!");  
// }

  


// Console.ReadLine();