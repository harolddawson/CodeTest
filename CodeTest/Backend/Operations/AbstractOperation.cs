namespace CodeTest.Backend.Operations
{
  public abstract class AbstractOperation<T> : IOperation<T>
  {
    public AbstractOperation(T left, T right)
    {
      Left = left;
      Right = right;
    }

    public virtual T Left { get; }

    public virtual T Right { get; }

    public abstract T Evaluate();
  }
}