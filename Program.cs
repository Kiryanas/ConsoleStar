using System;
namespace ConsoleAppNastya
{
    public class NastyaProgramMovingStar
    {
        static void Main(string[] args)
        {
            MovingStar star = new MovingStar();
            star.Moving();
        }
    }

    public class MovingStar
    {
        private int x = 10;
        private int y = 10;
        public void Moving()
        {
            Console.CursorVisible = false;
            ConsoleKeyInfo UserKey;
            do
            {
                Console.SetCursorPosition(this.x, this.y);
                Console.Write("*");
                UserKey = ProcessUserInput();
                Console.Clear();
                x = CorrectingCoordinate(x);
                y = CorrectingCoordinate(y);
            } while (UserKey.Key != ConsoleKey.Escape);
        }

        public ConsoleKeyInfo ProcessUserInput()
        {
            ConsoleKeyInfo UserKey = Console.ReadKey(true);
            if (UserKey.Key == ConsoleKey.UpArrow)
                y--;
            else if (UserKey.Key == ConsoleKey.DownArrow)
                y++;
            else if (UserKey.Key == ConsoleKey.LeftArrow)
                x--;
            else if (UserKey.Key == ConsoleKey.RightArrow)
                x++;
            return UserKey;
        }

        public static int CorrectingCoordinate(int CoordinateValue)
        {
            if (CoordinateValue <= 0) return 0;
            if (CoordinateValue >= 119) return 119;
            else return CoordinateValue;
        }
    }
}