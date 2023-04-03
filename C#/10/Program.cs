Console.WriteLine($"Qual a largura da parede em metros?");
float largura = float.Parse(Console.ReadLine());
Console.WriteLine($"Qual o comrimento da parede em metros?");
float comp = float.Parse(Console.ReadLine());
Console.WriteLine($"A parede tem uma área de {largura * comp}m², que precisará de {largura * comp / 2} litros de tinta para ser pintada");