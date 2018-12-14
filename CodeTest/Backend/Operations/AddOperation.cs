using System;

namespace CodeTest.Backend.Operations
{
  public class AddOperation : AbstractOperation<int>
  {
    public AddOperation(int left, int right) : base(left, right)
    {
    }

    public override int Evaluate()
    {
      return Left + Right;
    }
  }
}