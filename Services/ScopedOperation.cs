using System;

namespace DI.LifeTimes.WebApp.Services
{
    public interface IScopedOperation : IOperation
    {
    }

    public class ScopedOperation : IScopedOperation
    {
        public Guid Id { get; }

        public ScopedOperation()
        {
            Id = Guid.NewGuid();
        }
    }
}
