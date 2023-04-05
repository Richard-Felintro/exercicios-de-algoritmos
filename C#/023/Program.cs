bool feminino = false;

Console.WriteLine($"Informe seu nome:");
string nome = Console.ReadLine();

sexo:
Console.WriteLine($@"Informe seu sexo:
[M] Masculino
[F] Feminino");
string sexo = Console.ReadLine();
switch (sexo) {
    case "M":
    feminino = false;
    break;
    case "F":
    feminino = true;
    break;
    default:
    Console.WriteLine($"-+-+- Valor inválido -+-+-");
    goto sexo;
    break;
}
Console.WriteLine($"Informe o valor de suas compras:");
float custo = float.Parse(Console.ReadLine());
if (feminino = false){
    custo = (float)(custo * 0.87);
}
else{
    custo = (float)(custo * 0.95);
}
Console.WriteLine($"Levando o disconto de dia das mulheres em conta seu total é R${custo}");
