using System;

namespace CodeTest.Backend.Operations
{
  public class SubtractOperation : AbstractOperation<int>
  {
    public SubtractOperation(int left, int right) : base(left, right)
    {
    }

    public override int Evaluate()
    {
      return Left + Right;
    }
  }
}