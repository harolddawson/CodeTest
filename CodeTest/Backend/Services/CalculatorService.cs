using CodeTest.Backend.Operations;
using CodeTest.Services;

namespace CodeTest.Backend.Services
{
  public class CalculatorService : ICalculatorService
  {
    public T Calculate<T>(IOperation<T> operation) => operation.Evaluate();
  }
}