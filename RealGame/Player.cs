using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Player
{
    public int x_position;
    public int y_position;
    public bool have_key = false;

    public void CreatePlayer(int x, int y)
    {
        x_position = x;
        y_position = y;
        World.walls[y, x] = '0';
    }

    public void Move(ConsoleKeyInfo pressed_key)
    {
        if (pressed_key.Key == ConsoleKey.RightArrow && World.walls[y_position, x_position + 1] != '█') // движение вправо
        {
            Console.SetCursorPosition(x_position, y_position);
            Console.Write(' ');
            World.walls[y_position, x_position] = ' ';

            x_position++;

            Console.SetCursorPosition(x_position, y_position);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write('0');
            Console.ResetColor();
            World.walls[y_position, x_position] = '0';
            Thread.Sleep(50);
        }

        if (pressed_key.Key == ConsoleKey.LeftArrow && World.walls[y_position, x_position - 1] != '█' && World.walls[y_position, x_position - 1] != '║') // движение влево ║
        {
            Console.SetCursorPosition(x_position, y_position);
            Console.Write(' ');
            World.walls[y_position, x_position] = ' ';

            x_position--;

            Console.SetCursorPosition(x_position, y_position);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write('0');
            Console.ResetColor();
            World.walls[y_position, x_position] = '0';
            Thread.Sleep(50);
        }

        if (pressed_key.Key == ConsoleKey.LeftArrow && World.walls[y_position, x_position - 1] != '█' && World.walls[y_position, x_position - 1] == '║') // движение влево ║
        {
            if (have_key)
            {
                Console.SetCursorPosition(x_position, y_position);
                Console.Write(' ');
                World.walls[y_position, x_position] = ' ';

                x_position--;

                Console.SetCursorPosition(x_position, y_position);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write('0');
                Console.ResetColor();
                World.walls[y_position, x_position] = '0';
                Thread.Sleep(50);

                have_key = false;
                Console.SetCursorPosition(40, 6);
                Console.Write("   ");
            }
        }




        if (pressed_key.Key == ConsoleKey.UpArrow && World.walls[y_position - 1, x_position] != '█') // движение вверх
        {
            Console.SetCursorPosition(x_position, y_position);
            Console.Write(' ');
            World.walls[y_position, x_position] = ' ';

            y_position--;

            Console.SetCursorPosition(x_position, y_position);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write('0');
            Console.ResetColor();
            World.walls[y_position, x_position] = '0';
            Thread.Sleep(50);
        }

        if (pressed_key.Key == ConsoleKey.DownArrow && World.walls[y_position + 1, x_position] != '█' && World.walls[y_position+1, x_position] != '═') // движение вниз
        {
            Console.SetCursorPosition(x_position, y_position);
            Console.Write(' ');
            World.walls[y_position, x_position] = ' ';

            y_position++;

            Console.SetCursorPosition(x_position, y_position);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write('0');
            Console.ResetColor();
            World.walls[y_position, x_position] = '0';
            Thread.Sleep(50);
        }

        if (pressed_key.Key == ConsoleKey.DownArrow && World.walls[y_position + 1, x_position] != '█' && World.walls[y_position + 1, x_position] == '═') // движение вниз
        {
            if (have_key)
            {
                Console.SetCursorPosition(x_position, y_position);
                Console.Write(' ');
                World.walls[y_position, x_position] = ' ';

                y_position++;

                Console.SetCursorPosition(x_position, y_position);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write('0');
                Console.ResetColor();
                World.walls[y_position, x_position] = '0';
                Thread.Sleep(50);

                have_key = false;
                Console.SetCursorPosition(40, 6);
                Console.Write("   ");
            }
        }




    }
}
