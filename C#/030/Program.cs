// 30) [DESAFIO] Refaça o algoritmo 25, acrescentando o recurso de mostrar que tipo
// de triângulo será formado:
//  - EQUILÁTERO: todos os lados iguais
//  - ISÓSCELES: dois lados iguais
//  - ESCALENO: todos os lados diferentes

inicio:
Console.WriteLine($"Informe o comprimento da primeira reta:");
float reta1 = float.Parse(Console.ReadLine());
Console.WriteLine($"Informe o comprimento da segunda reta:");
float reta2 = float.Parse(Console.ReadLine());
Console.WriteLine($"Informe o comprimento da terceira reta:");
float reta3 = float.Parse(Console.ReadLine());

if (reta1 > reta2 + reta3 || reta2 > reta1 + reta3 || reta3 > reta2 + reta1){
Console.WriteLine($"Este triângulo não é fisicamente possível, refaça suas medidas.");
goto inicio;
}
else{
    Console.WriteLine($"Este triângulo é fisicamente possível.");
}

if (reta1 == reta2 && reta1 == reta3 && reta2 == reta3){
    Console.WriteLine($"O triângulo em questão é equilátero.");
}
else if (reta1 != reta2 && reta1 != reta3 && reta2 != reta3){
    Console.WriteLine($"O triângulo em questão é escaleno.");
}
else{
    Console.WriteLine($"Este triângulo é isoceles.");
}