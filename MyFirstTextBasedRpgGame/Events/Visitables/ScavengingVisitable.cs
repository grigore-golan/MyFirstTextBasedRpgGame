namespace MyFirstTextBasedRpgGame.Events.Abstractions
{
    public class ScavengingVisitable : IVisitable
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
