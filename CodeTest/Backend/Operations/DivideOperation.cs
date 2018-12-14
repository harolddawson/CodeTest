using System;

namespace CodeTest.Backend.Operations
{
  public class DivideOperation : AbstractOperation<int>
  {
    public DivideOperation(int left, int right) : base(left, right)
    {
    }

    public override int Evaluate()
    {
      return Left / Right;
    }
  }
}