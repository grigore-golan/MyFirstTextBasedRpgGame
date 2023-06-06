namespace MyFirstTextBasedRpgGame.Events.Abstractions
{
    public class NpcVisitable : IVisitable
    {
        // TO DO: 
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
