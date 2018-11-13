using System;
using System.Threading.Tasks;

namespace mvc.Services
{
    public class AsyncService : IDisposable

    {
        public async Task<int> SomeMethodAsync()
        {
            await Task.Delay(5000).ConfigureAwait(false);
            return 100500;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // get rid of managed resources
            }
            // get rid of unmanaged resources
        }
    }
}