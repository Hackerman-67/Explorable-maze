
Game game = new Game(); // определение объекта для манипуляции с заставкой
World world = new World();
Player player = new Player();


Console.CursorVisible = false;


int width = World.walls.GetLength(0) - 1;
int height = World.walls.GetLength(1) - 1;
//bool have_key = false;



game.SetResolution(); // установка разрешения
game.ShowTitle(); // вывод картинки
link1: game.CheckKey(); // запрос клавиши на ввод


ConsoleKeyInfo key = game.pressed; // считывание клавиши с клавиатуры


if (key.Key == ConsoleKey.Q) { Console.Clear(); Environment.Exit(0); } // если q, то игра вылетает
else if (key.Key == ConsoleKey.S)
{
    Console.Clear();
    player.CreatePlayer(1, 1);
    world.CreateWalls();
    world.ShowCooridnates(player);
    world.SpawnKey(9, 3);
    world.SpawnKey(25, 8);
    world.SpawnExit(1, 22);

    Console.SetCursorPosition(player.x_position, player.y_position);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write('0');
    Console.ResetColor();

    while (true)
    {
        ConsoleKeyInfo direction = Console.ReadKey(true);

        if (direction.Key == ConsoleKey.Q) break;

        player.Move(direction);

        world.ShowCooridnates(player);


        if (player.x_position == 9 && player.y_position == 3)
        {
            player.have_key = true;
            Console.SetCursorPosition(40, 6);
            Console.Write("(1)");
        }
        if (player.x_position == 25 && player.y_position == 8)
        {
            player.have_key = true;
            Console.SetCursorPosition(40, 6);
            Console.Write("(1)");
        }
        if (player.x_position == 1 && player.y_position == 22)
            break;
    }

    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Игра завершена");
    Environment.Exit(0);
}
else
{
    goto link1; // это отвратительно, но необходимо для простоты
}
