Console.WriteLine($"Informe a quantia de cigarros fumados por dia:");
int cigarrosDiarios = int.Parse(Console.ReadLine());
Console.WriteLine($"Informe há quantos anos o hábito de fumo tem persistido");
int anos = int.Parse(Console.ReadLine());
Console.WriteLine($"O fumante perdeu um total de {Math.Round((cigarrosDiarios*365.25*anos*10)/1440,0)} dias de vida por conta do fumo.");
