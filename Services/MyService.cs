namespace DI.LifeTimes.WebApp.Services
{
    public interface IMyService
    {
    }

    public class MyService : IMyService
    {
        private readonly ISingletonOperation _singletonOperation;
        private readonly ITransientOperation _transientOperation;
        private readonly IScopedOperation _scopedOperation;


        public MyService
         (
             ISingletonOperation singletonOperation,
             ITransientOperation transientOperation,
             IScopedOperation scopedOperation
         )
        {
            _singletonOperation = singletonOperation;
            _transientOperation = transientOperation;
            _scopedOperation = scopedOperation;
        }
    }
}
