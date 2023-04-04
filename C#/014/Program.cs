Console.WriteLine($"Quantos quilometros foram percorridos com o carro alugado?");
float km = int.Parse(Console.ReadLine());
Console.WriteLine($"Por quantos dias o carro foi alugado?");
float dias = int.Parse(Console.ReadLine());
Console.WriteLine($"O total a ser pago é R${Math.Round(km * 0.2 + dias * 90,2)}");