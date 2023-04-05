Console.WriteLine($"Informe o nome do aluno:");
string nome = Console.ReadLine();
Console.WriteLine($"Informe a primeira nota do aluno:");
float nota1 = float.Parse(Console.ReadLine());
Console.WriteLine($"Informe a segunda nota do aluno:");
float nota2 = float.Parse(Console.ReadLine());
float media = (nota1 + nota2)/2;
if (media > 7)
Console.WriteLine($"O aluno {nome} foi aprovado com uma média de {media}");
else 
Console.WriteLine($"O aluno {nome} foi reprovado com uma média de {media}");