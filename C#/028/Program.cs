// 28) Faça um programa que leia a largura e o comprimento de um terreno
// retangular, calculando e mostrando a sua área em m². O programa também
// devemostrar a classificação desse terreno, de acordo com a lista abaixo:
//  - Abaixo de 100m² = TERRENO POPULAR
//  - Entre 100m² e 500m² = TERRENO MASTER
//  - Acima de 500m² = TERRENO VIP
Console.WriteLine($"Informe o comprimento do terreno (em metros):");
float comp = float.Parse(Console.ReadLine());
Console.WriteLine($"Informe a largura do terreno (em metros):");
float larg = float.Parse(Console.ReadLine());
float area = comp * larg;

Console.WriteLine($"Area total do terreno: {area}m².");
if (area < 100){
    Console.WriteLine($"TERRENO POPULAR");
}
else if(area > 500){
    Console.WriteLine($"TERRENO VIP");
}
else {
    Console.WriteLine($"TERRENO MASTER");
}