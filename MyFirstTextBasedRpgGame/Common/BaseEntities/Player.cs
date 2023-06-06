namespace MyFirstTextBasedRpgGame.Common.BaseEntities
{
    public sealed class Player
    {
        private static Player _instance;
        private static object _instanceLock = new();

        public string Name { get; private set; }
        public int Level { get; private set; }
        public const string Pronoun = "You";

        private Player() 
        {
            this.Name = "Adventurer";
            this.Level = 1;
        }

        public static Player GetInstance()
        {
            if (_instance == null)
                lock (_instanceLock)
                    if (_instance == null)
                        _instance = new Player();

            return _instance;
        }

        public void Rename (string name)
        {
            this.Name = name;
        }
    }
}
