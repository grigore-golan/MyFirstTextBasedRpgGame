namespace MyFirstTextBasedRpgGame.Common
{
    public static class Randomizer
    {
        public static int GetRandomUpTo100()
        {
            Random rnd = new();
            int num = rnd.Next(100);

            return num;
        }
    }
}
