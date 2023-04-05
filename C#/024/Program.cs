Console.WriteLine($"Informe a distância percorrida em Km");
double distancia = float.Parse(Console.ReadLine());
if (distancia > 200){
    Console.WriteLine($"Sua cobraça é de R${Math.Round(distancia*0.45, 2)}");
}
else{
        Console.WriteLine($"Sua cobraça é de R${Math.Round(distancia*0.5, 2)}");
}