Console.Clear();

int player1 = 0;
int player2 = 0;
int health1 = 0;
int health2 = 0;
int attack1 = 0;
int attack2 = 0;
int speed1 = 0;
int speed2 = 0;
int armor1 = 0;
int armor2 = 0;
int pirate = 1;
int stonechewer = 2;
int ghostwarrior = 3;
int outworlder = 4;
int monsterknight = 5;
int darkgoblin = 6;

Console.WriteLine("Player 1, choose your fighter!");
Console.WriteLine("Pirate (1), Stonechewer(2), Ghostwarrior(3), Outworlder(4), Monsterknight(5), Darkgoblin(6)");
player1 = int.Parse(Console.ReadLine()!);

if (player1 == pirate) { health1 += 20; attack1 += 3; armor1 += 3; speed1 += 3; }
else if (player1 == stonechewer) { health1 += 50; attack1 += 8; armor1 += 10; speed1 += 1; }
else if (player1 == ghostwarrior) { health1 += 20; attack1 += 2; armor1 += 2; speed1 += 5; }
else if (player1 == outworlder) { health1 += 15; attack1 += 1; armor1 += 2; speed1 += 10; }
else if (player1 == monsterknight) { health1 += 15; attack1 += 4; armor1 += 3; speed1 += 3; }
else if (player1 == darkgoblin) { health1 += 10; attack1 += 1; armor1 += 8; speed1 += 3; }

Console.WriteLine("Player 2, choose your fighter!");
Console.WriteLine("Pirate (1), Stonechewer(2), Ghostwarrior(3), Outworlder(4), Monsterknight(5), Darkgoblin(6)");
player2 = int.Parse(Console.ReadLine()!);

if (player2 == pirate) { health2 += 20; attack2 += 3; armor2 += 3; speed2 += 3; }
else if (player2 == stonechewer) { health2 += 50; attack2 += 8; armor2 += 10; speed2 += 1; }
else if (player2 == ghostwarrior) { health2 += 20; attack2 += 2; armor2 += 2; speed2 += 5; }
else if (player2 == outworlder) { health2 += 15; attack2 += 1; armor2 += 2; speed2 += 10; }
else if (player1 == monsterknight) { health2 += 15; attack2 += 4; armor2 += 3; speed2 += 3; }
else if (player1 == darkgoblin) { health2 += 10; attack2 += 1; armor2 += 8; speed2 += 3; }


while (health1 > 0 && health2 > 0)
{
    health1 = health1 + armor1 - attack2 * speed2;
    health2 = health2 + armor2 - attack1 * speed1;
}

if (health1 > 0) { Console.WriteLine("Player1 won!"); }
else if (health2 > 0) { Console.WriteLine("Player2 won!"); }
else if (health1 == health2) { Console.WriteLine("Draw! Nobody won."); }

Console.ReadKey();
Console.Clear();