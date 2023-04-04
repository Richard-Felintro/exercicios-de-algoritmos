Console.WriteLine($"Informe a velocidade do carro (em Km/h):");
float velocidade = float.Parse(Console.ReadLine());
if (velocidade <= 80){
    Console.WriteLine($"Você está abaixo do limite de velocidade, pode prosseguir.");
}
else{
    Console.WriteLine($"Você ultrapassou o limite de velocidade e recebeu uma multa de R${Math.Round((velocidade-80) * 5,2)}");
}