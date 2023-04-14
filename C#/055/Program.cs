// 55) [DESAFIO] Vamos melhorar o jogo que fizemos no exercício 32. A partir de
// agora, o computador vai sortear um número entre 1 e 10 e o jogador vai ter 4
// tentativas para tentar acertar.
// 32) [DESAFIO] Crie um jogo onde o computador vai sortear um número entre 1 e 5 o
// jogador vai tentar descobrir qual foi o valor sorteado.
Random rnd = new Random();
int numero = rnd.Next(1, 11);
Console.WriteLine($"Adivinhe o número!");
Console.WriteLine($"Insira um número inteiro:");
int adiv = -5;
for (var i = 1; i <= 4; i++)
{
    adiv = int.Parse(Console.ReadLine());
    if (adiv == numero)
    {
        Console.WriteLine($"PARABÉNS! Você adivinhou que o número correto era {adiv}.");
        i = 4;
    }
    else
    {
        if (i == 3)
        {
            Console.WriteLine($"ERROU! Ultima tentativa.");
        }
        else
        {
            Console.WriteLine($"ERROU! Você tem {4 - i} tentativas sobrando.");
        }
    }
}