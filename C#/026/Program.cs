// 26) Escreva um algoritmo que leia dois números inteiros e compare-os, mostrando
// na tela uma das mensagens abaixo:
//  - O primeiro valor é o maior
//  - O segundo valor é o maior
//  - Não existe valor maior, os dois são iguais
Console.WriteLine($"Insira o primeiro número inteiro:");
int numero1 = int.Parse(Console.ReadLine());
Console.WriteLine($"Insira o segundo número inteiro:");
int numero2 = int.Parse(Console.ReadLine());
if(numero1 > numero2){
    Console.WriteLine($"O primeiro número é maior que o segundo.");
}
else if(numero2 > numero1){
    Console.WriteLine($"O segundo número é maior que o primeiro.");
}
else{
    Console.WriteLine($"Ambos os valores são iguais.");
}