#nullable enable

namespace Whoop
{
    public partial interface ISleepClient
    {
        /// <summary>
        /// Get the raw signal stream for the specified sleep ID.
        /// </summary>
        /// <param name="sleepId"></param>
        /// <param name="types"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Whoop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Whoop.SleepStreamResponse> GetSleepStreamAsync(
            global::System.Guid sleepId,
            global::System.Collections.Generic.IList<global::Whoop.GetSleepStreamType>? types = default,
            global::Whoop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the raw signal stream for the specified sleep ID.
        /// </summary>
        /// <param name="sleepId"></param>
        /// <param name="types"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Whoop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Whoop.AutoSDKHttpResponse<global::Whoop.SleepStreamResponse>> GetSleepStreamAsResponseAsync(
            global::System.Guid sleepId,
            global::System.Collections.Generic.IList<global::Whoop.GetSleepStreamType>? types = default,
            global::Whoop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}