#nullable enable

namespace Whoop
{
    public partial interface ISleepClient
    {
        /// <summary>
        /// Get the sleep for the specified ID
        /// </summary>
        /// <param name="sleepId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Whoop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Whoop.Sleep> GetSleepByIdAsync(
            global::System.Guid sleepId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}