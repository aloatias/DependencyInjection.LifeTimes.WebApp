using System;

namespace DI.LifeTimes.WebApp.Services
{
    public interface ITransientOperation : IOperation
    {
    }

    public class TransientOperation : ITransientOperation
    {
        public Guid Id { get; }

        public TransientOperation()
        {
            Id = Guid.NewGuid();
        }
    }
}
