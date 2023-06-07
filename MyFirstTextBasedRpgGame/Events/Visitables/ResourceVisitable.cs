namespace MyFirstTextBasedRpgGame.Events.Abstractions
{
    public class ResourceVisitable : IVisitable
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
