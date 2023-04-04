Console.WriteLine($"Informe seu  ano de nascimento:");
int ano = int.Parse(Console.ReadLine());
if(ano > DateTime.Now.Year) {
    Console.WriteLine($"Este ano ainda não chegou.");
}
else if (ano >= DateTime.Now.Year - 18){
    Console.WriteLine($"Você ainda não pode votar");
}
else {
    Console.WriteLine($"Você pode votar!");
}