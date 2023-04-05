Console.WriteLine($"Informe o comprimento da primeira reta:");
double reta1 = double.Parse(Console.ReadLine());
Console.WriteLine($"Informe o comprimento da segunda reta:");
double reta2 = double.Parse(Console.ReadLine());
Console.WriteLine($"Informe o comprimento da terceira reta:");
double reta3 = double.Parse(Console.ReadLine());

if (reta1 > reta2 + reta3 || reta2 > reta1 + reta3 || reta3 > reta2 + reta1){
Console.WriteLine($"Este triângulo não é fisicamente possível.");
}
else{
    Console.WriteLine($"Este triângulo é fisicamente possível.");
}