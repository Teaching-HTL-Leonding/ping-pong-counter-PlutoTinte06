int gametype = 0;
int games = 0;
const int S = 1;
const int R = 2;
const int D = 3;
int points1 = 0;
int points2 = 0;
int games1 = 0;
int games2 = 0;
int matchwon = 0;

Console.WriteLine("What type of match will be played?: 1...short, 2...regular or 3...double ");
gametype = int.Parse(Console.ReadLine()!);

switch (gametype)
{
    case S:
        games = 1;
        break;

    case R:
        games = 4;
        break;

    case D:
        games = 3;
        break;
}

do
{
    points1 = points2 = 0;
    do
    {
        Console.WriteLine("Who has won the point?");
        string quit = Console.ReadLine()!;
        if (quit == "q") { return; }
        int pointwon = int.Parse(Console.ReadLine()!);
        if (pointwon == 1) { points1++; }
        else if (pointwon == 2) { points2++; }
        Console.WriteLine($"Points: {points1}:{points2}");

    } while (points1 != 11 && points2 != 11);

    if (points1 == 11) { Console.WriteLine("Player1 won the game!"); games1++; }
    else if (points2 == 11) { Console.WriteLine("Player2 won the game!"); games2++; }
    Console.WriteLine($"Games: {games1}:{games2}");

} while (games1 != games && games2 != games);

if (games1 == games) { Console.WriteLine("Player 1 has won the match!"); }
else if (games2 == games) { Console.WriteLine("Player 2 has won the match!"); }

switch (matchwon)
{
    case S:
        games1 = games;
        Console.WriteLine("Player1 won the match!");
        games2 = games;
        Console.WriteLine("Player2 won the match!");
        break;

    case R:
        games1 = games;
        Console.WriteLine("Player1 won the match!");
        games2 = games;
        Console.WriteLine("Player2 won the match!");
        break;

    case D:
        games1 = games;
        Console.WriteLine("Player1 won the match!");
        games2 = games;
        Console.WriteLine("Player2 won the match!");
        break;
}