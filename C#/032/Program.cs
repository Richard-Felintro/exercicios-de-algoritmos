// 32) [DESAFIO] Crie um jogo onde o computador vai sortear um número entre 1 e 5 o
// jogador vai tentar descobrir qual foi o valor sorteado.
Random rnd = new Random();
int numero = rnd.Next(1,6);
Console.WriteLine($"Adivinhe o número!");
int adiv = int.Parse(Console.ReadLine());
if (numero == adiv){
    Console.WriteLine($"Você acertou, o número era {numero}!");
}
else{
    Console.WriteLine($"Você errou, o número correto era {numero}!");
}