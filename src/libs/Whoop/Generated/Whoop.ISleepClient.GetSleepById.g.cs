#nullable enable

namespace Whoop
{
    public partial interface ISleepClient
    {
        /// <summary>
        /// Get the sleep for the specified ID
        /// </summary>
        /// <param name="sleepId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Whoop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Whoop.Sleep> GetSleepByIdAsync(
            global::System.Guid sleepId,
            global::Whoop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}