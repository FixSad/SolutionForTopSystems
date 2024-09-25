namespace ConsoleDrawer
{
    internal class Drawer : IDrawer
    {
        private readonly char _symbol = '.';
        public void Draw(int x, int y, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(x, y);
            Console.Write(_symbol);
        }

        public void Erase(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(' ');
        }
    }
}
