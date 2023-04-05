Console.WriteLine($"Informe o seu ano de nascimento:");
int ano = int.Parse(Console.ReadLine());
int idade = DateTime.Now.Year - ano;
if (idade == 18)
Console.WriteLine($"Seu alistamento é esse ano");
else if (idade < 18)
Console.WriteLine($"Seu alistamento será em {18 - idade} anos.");
else
Console.WriteLine($"Seu alistamento foi há {idade - 18} anos atrás.");