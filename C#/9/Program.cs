Console.WriteLine($"Quantos reais você tem em sua carteira?");
float real = float.Parse(Console.ReadLine());
Console.WriteLine($"Você tem o equivalente a ${Math.Round(real / 3.75, 2) } dólares");
