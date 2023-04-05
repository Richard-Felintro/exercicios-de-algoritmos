Console.WriteLine($"Digite um ano");
int ano = int.Parse(Console.ReadLine());
if (ano % 4 == 0)
Console.WriteLine($"O ano {ano} é bissexto.");
else
Console.WriteLine($"O ano {ano} não é bissexto.");