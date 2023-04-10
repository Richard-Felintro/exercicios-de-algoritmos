// 29) Desenvolva um programa que leia o nome de um funcionário, seu salário,
// quantos anos ele trabalha na empresa e mostre seu novo salário, reajustado de
// acordo com a tabela a seguir:
//  - Até 3 anos de empresa: aumento de 3%
//  - entre 3 e 10 anos: aumento de 12.5%
//  - 10 anos ou mais: aumento de 20%
Console.WriteLine($"Informe o nome do funcionário:");
string nome = Console.ReadLine();
Console.WriteLine($"Informe o salário do funcionário:");
float salario = float.Parse(Console.ReadLine());
Console.WriteLine($"Informe o período de trabalho do funcionário na empresa em anos:");
float tempo = float.Parse(Console.ReadLine());
double aumento = 1.125;

if (tempo < 3){
    aumento = 1.03;
}
else if (tempo > 10){
    aumento = 1.20;
}
else{}

Console.WriteLine($"O novo salário de {nome} será R${salario * aumento}");
