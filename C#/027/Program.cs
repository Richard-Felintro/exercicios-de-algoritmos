// 27) Crie um programa que leia duas notas de um aluno e calcule a sua média,
// mostrando uma mensagem no final, de acordo com a média atingida:
//  - Média até 4.9: REPROVADO
//  - Média entre 5.0 e 6.9: RECUPERAÇÃO
//  - Média 7.0 ou superior: APROVADO
Console.WriteLine($"Informe a primeira nota do aluno:");
float nota1 = float.Parse(Console.ReadLine());
Console.WriteLine($"Informe a segunda nota do aluno:");
float nota2 = float.Parse(Console.ReadLine());
float media = (nota1 + nota2)/2;
if (media < 5){
    Console.WriteLine($"REPROVADO");
}
else if (media >= 7){
    Console.WriteLine($"APROVADO");
}
else{
    Console.WriteLine($"RECUPERAÇÃO");
}