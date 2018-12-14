using System;

namespace CodeTest.Backend.Operations
{
  public class MultiplyOperation : AbstractOperation<int>
  {
    public MultiplyOperation(int left, int right) : base(left, right)
    {
    }

    public override int Evaluate()
    {
      return Left * Right;
    }
  }
}