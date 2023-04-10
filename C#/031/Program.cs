// 31) [DESAFIO] Crie um jogo de JoKenPo (Pedra-Papel-Tesoura)
string j1 = "";
bool primeiro = true;

while (primeiro == true)
{
    Console.WriteLine($@"
Jogador 2, escolha sua jogada:
o-----+o+-----o
| [1] Pedra   |
| [2] Papel   |
| [3] Tesoura |
o-----+o+-----o");
    string jogada1 = Console.ReadLine();
    switch (jogada1)
    {
        case "1":
            j1 = "pedra";
            primeiro = false;
            break;
        case "2":
            j1 = "papel";
            primeiro = false;
            break;
        case "3":
            j1 = "tesoura";
            primeiro = false;
            break;
        default:
            Console.WriteLine($"Valor inválido.");
            break;
    }
}

string j2 = "";
bool segundo = true;
while (segundo == true)
{
    Console.WriteLine($@"JoKenPo!
Jogador 2, escolha sua jogada:
o-----+o+-----o
| [1] Pedra   |
| [2] Papel   |
| [3] Tesoura |
o-----+o+-----o");
    string jogada2 = Console.ReadLine();
    switch (jogada2)
    {
        case "1":
            j2 = "pedra";
            segundo = false;
            break;
        case "2":
            j2 = "papel";
            segundo = false;
            break;
        case "3":
            j2 = "tesoura";
            segundo = false;
            break;
        default:
            Console.WriteLine($"Valor inválido.");
            break;
    }
}

if (j1 == j2)
{
    Console.WriteLine($"EMPATE");
}

else if (j1 == "papel" && j2 == "pedra" || j1 == "pedra" && j2 == "tesoura" || j1 == "tesoura" && j2 == "papel")
{
    Console.WriteLine($"JOGADOR 1 É O VENCEDOR!");
}
else
{
    Console.WriteLine($"JOGADOR 2 É O VENCEDOR!");
}
