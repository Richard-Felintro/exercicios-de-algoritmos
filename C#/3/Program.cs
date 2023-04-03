Console.WriteLine($"Qual o nome do funcionário?");
string nome = Console.ReadLine();
Console.WriteLine($"Qual o salário do funcionário?");
float salario = float.Parse(Console.ReadLine());

Console.WriteLine($@"
Nome do funcionário: {nome}
Salário do funcionário: R${salario}");
