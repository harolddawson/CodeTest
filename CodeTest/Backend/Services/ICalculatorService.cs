using CodeTest.Backend.Operations;

namespace CodeTest.Services
{
    public interface ICalculatorService
    {
        T Calculate<T>(IOperation<T> operation);
    }
}