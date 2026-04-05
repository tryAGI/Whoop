#nullable enable

namespace Whoop
{
    public partial interface ICycleClient
    {
        /// <summary>
        /// Get the sleep for the specified cycle ID
        /// </summary>
        /// <param name="cycleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Whoop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Whoop.Sleep> GetSleepForCycleAsync(
            long cycleId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}