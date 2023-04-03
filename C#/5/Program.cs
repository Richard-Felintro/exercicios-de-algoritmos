Console.WriteLine($@"Calculadora de média
Qual a primeira nota do aluno:");
float n1 = float.Parse(Console.ReadLine());
Console.WriteLine($"Qual a segunda média do aluno?");
float n2 = float.Parse(Console.ReadLine());
Console.WriteLine($"A média do aluno é {(n1 + n2) / 2}");