namespace CodeTest.Backend.Operations
{
    public interface IOperation<T>
    {
        T Left { get; }
        T Right { get; }
        T Evaluate();
    }
}