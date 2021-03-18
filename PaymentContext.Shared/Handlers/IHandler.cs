using PaymentContext.Shared.Commands;

namespace PaymentContext.Shared.Handler
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}
