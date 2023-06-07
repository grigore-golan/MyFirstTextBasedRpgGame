using MyFirstTextBasedRpgGame.Events.Abstractions;

namespace MyFirstTextBasedRpgGame.Events
{
    public static class EventGenerator
    {
        public static IVisitable Generate()
        {
            if (Randomizer.GetRandomUpTo100() > 85)
            {
                return new ResourceVisitable();
            }
            else
            {
                return new EnemyVisitable();
            }
        }
    }
}
