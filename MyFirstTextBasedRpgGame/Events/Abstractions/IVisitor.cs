namespace MyFirstTextBasedRpgGame.Events.Abstractions
{
    public interface IVisitor
    {
        public void Visit(EnemyVisitable visitable);
        public void Visit(ResourceVisitable visitable);
    }
}
