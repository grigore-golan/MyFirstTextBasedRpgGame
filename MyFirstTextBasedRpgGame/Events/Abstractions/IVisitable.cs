namespace MyFirstTextBasedRpgGame.Events.Abstractions
{
    public interface IVisitable
    {
        public void Accept(IVisitor visitor);
    }
}
