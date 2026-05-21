#nullable enable

namespace Whoop
{
    public partial interface IRecoveryClient
    {
        /// <summary>
        /// Get the recovery for a cycle
        /// </summary>
        /// <param name="cycleId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Whoop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Whoop.Recovery> GetRecoveryForCycleAsync(
            long cycleId,
            global::Whoop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the recovery for a cycle
        /// </summary>
        /// <param name="cycleId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Whoop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Whoop.AutoSDKHttpResponse<global::Whoop.Recovery>> GetRecoveryForCycleAsResponseAsync(
            long cycleId,
            global::Whoop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}