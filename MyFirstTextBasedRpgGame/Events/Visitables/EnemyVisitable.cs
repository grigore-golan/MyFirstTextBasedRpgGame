namespace MyFirstTextBasedRpgGame.Events.Abstractions
{
    public class EnemyVisitable : IVisitable
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
