Console.WriteLine($"Qual o preço do produto?");
float preco = float.Parse(Console.ReadLine());
Console.WriteLine($"O preço promocional do produto é R${Math.Round(preco * 0.95, 2)}");
