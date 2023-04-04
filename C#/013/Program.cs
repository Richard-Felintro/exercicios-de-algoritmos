Console.WriteLine($"Qual o salário do funcionário em questão");
float salario = float.Parse(Console.ReadLine());
Console.WriteLine($"O salário do funcionário será R${Math.Round(salario * 1.15)} após o seu aumento de 15%");
