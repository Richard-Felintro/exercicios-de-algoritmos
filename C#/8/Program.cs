Console.WriteLine($"Digite uma distância em metros:");
float metro = float.Parse(Console.ReadLine());
Console.WriteLine($@"A distância de {metro}m corresponde a:
{metro / 1000}Km
{metro / 100}Hm
{metro / 10}Dam
{metro * 10}dm
{metro * 100}cm
{metro * 1000}mm");
