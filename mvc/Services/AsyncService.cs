using System.Threading.Tasks;

namespace mvc.Services
{
    public class AsyncService
    {
        public async Task SomeMethodAsync()
        {
            await Task.Delay(1000).ConfigureAwait(false);
        }
    }
}