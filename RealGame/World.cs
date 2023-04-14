using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class World
  {

    static public char[,] walls = new char[,]
    {
        {'█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█'},
        {'█', ' ', '█', ' ', ' ', ' ', '█', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '█'},
        {'█', ' ', '█', ' ', '█', ' ', '█', ' ', '█', '█', '█', '█', '█', '█', ' ', '█', '█', '█', '█', '█', '█', '█', '█', ' ', '█', '█', '█', ' ', '█'},
        {'█', ' ', '█', ' ', '█', ' ', '█', ' ', '█', ' ', ' ', ' ', ' ', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', ' ', '█'},
        {'█', ' ', '█', ' ', '█', ' ', '█', ' ', '█', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '█', ' ', ' ', ' ', '█', ' ', '█'},
        {'█', ' ', '█', ' ', '█', ' ', '█', ' ', '█', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '█', ' ', ' ', ' ', ' ', ' ', '█'},
        {'█', ' ', ' ', ' ', '█', ' ', ' ', ' ', '█', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '█', ' ', '█'},
        {'█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '═', '█'}, //
        {'█', '█', '█', '█', ' ', ' ', ' ', '█', ' ', ' ', ' ', ' ', '█', ' ', '║', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '█', 'o', '█', ' ', '█'}, // ║
        {'█', '█', ' ', ' ', ' ', '█', ' ', ' ', ' ', '█', '█', ' ', '█', ' ', '█', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '█', ' ', '█', ' ', '█', ' ', '█'},
        {'█', '█', ' ', '█', '█', '█', '█', '█', '█', '█', '█', ' ', ' ', ' ', '█', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '█', ' ', ' ', ' ', '█', ' ', '█'},
        {'█', '█', ' ', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', ' ', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', ' ', '█'},
        {'█', ' ', ' ', '█', '█', '█', '░', '░', '░', '░', '░', '█', '█', '█', '█', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '█', ' ', ' ', ' ', ' ', '█'},
        {'█', ' ', '█', '█', '█', '░', '░', '░', '░', '░', '░', '░', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', ' ', '█', '█', ' ', '█', ' ', '█'},
        {'█', ' ', '█', '█', '░', '░', '░', '░', '░', '░', '░', '░', '░', '█', '█', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '█', '█', ' ', '█', '█', '█'},
        {'█', ' ', '█', '█', '░', '█', '█', '░', '░', '░', '█', '█', '░', '█', '█', ' ', '█', ' ', '█', '█', '█', '█', '█', '█', '█', ' ', '█', ' ', '█'},
        {'█', ' ', '█', '█', '░', '█', '█', '░', '░', '░', '█', '█', '░', '█', '█', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '█', ' ', ' ', ' ', ' ', '█'},
        {'█', ' ', '█', '█', '░', '░', '░', '░', '█', '░', '░', '░', '░', '█', '█', '█', '█', '█', '█', '█', ' ', '█', '█', '█', '█', '█', '█', ' ', '█'},
        {'█', ' ', '█', '█', '░', '░', '░', '░', '░', '░', '░', '░', '░', '█', '█', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '█', '█', '█', '█', ' ', '█'},
        {'█', ' ', '█', '█', '█', '░', '░', '░', '░', '░', '░', '░', '█', '█', '█', ' ', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', ' ', '█'},
        {'█', ' ', ' ', ' ', '█', '█', '░', '░', '░', '░', '░', '█', '█', '█', '█', ' ', '█', '█', '█', ' ', ' ', ' ', ' ', ' ', '█', '█', '█', ' ', '█'},
        {'█', '█', '█', ' ', '█', '█', '░', '█', '░', '█', '░', '█', '█', '█', '█', ' ', '█', '█', '█', ' ', '█', '█', '█', ' ', '█', '█', '█', ' ', '█'},
        {'█', 'X', ' ', ' ', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', ' ', ' ', ' ', ' ', ' ', ' ', '█', ' ', ' ', ' ', ' ', ' ', ' ', '█'},
        {'█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█'}
    };

    public void CreateWalls()
    {
        for(int i = 0; i < walls.GetLength(0); i++)
            {
            for (int j = 0; j < walls.GetLength(1); j++)
            {
                Console.Write(walls[i, j]);
            }
            Console.WriteLine();
        }

        Console.SetCursorPosition(31, 1);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("     Легенда");
        Console.SetCursorPosition(31, 2);
        Console.Write("-----------------");

        Console.SetCursorPosition(31, 4);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("0");
        Console.ResetColor();
        Console.Write(" - ваш персонаж");

        /*Console.SetCursorPosition(31, 6);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("S");
        Console.ResetColor();
        Console.Write(" - противники"); */

        Console.SetCursorPosition(31, 6);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("o");
        Console.ResetColor();
        Console.Write(" - ключ");

        Console.SetCursorPosition(31, 8);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("X");
        Console.ResetColor();
        Console.Write(" - выход");

        Console.SetCursorPosition(31, 10);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("-----------------");
        Console.ResetColor();

        Console.SetCursorPosition(31, 18);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("-----------------");
        Console.ResetColor();


        Console.SetCursorPosition(31, 20);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Q");
        Console.ResetColor();
        Console.Write(" - завершить игру");

        Console.SetCursorPosition(31, 22);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("-----------------");
        Console.ResetColor();

    }

    public void ShowCooridnates(Player player)
    {
        Console.SetCursorPosition(35, 14);
        Console.Write(' ');
        Console.SetCursorPosition(35, 16);
        Console.Write(' ');

        int x_coordinate = player.x_position;
        int y_coordinate = walls.GetLength(0) - player.y_position - 1;

        Console.SetCursorPosition(31, 12);
        Console.Write("Координаты игрока:");
        Console.SetCursorPosition (31, 14);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("X: ");
        Console.ResetColor();
        Console.Write(x_coordinate);

        Console.SetCursorPosition(31, 16);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Y: ");
        Console.ResetColor();
        Console.Write(y_coordinate);
    }

    public void SpawnKey(int x, int y)
    {
        walls[y, x] = 'o';

        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write('o');
        Console.ResetColor();
    }

    public void SpawnExit(int x, int y)
    {
        walls[y, x] = 'X';

        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write('X');
        Console.ResetColor();
    }

}
