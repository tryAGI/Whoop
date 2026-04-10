#nullable enable

namespace Whoop
{
    public partial interface ISleepClient
    {
        /// <summary>
        /// Get all sleeps for a user, paginated. Results are sorted by start time in descending order.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="nextToken"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Whoop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Whoop.PaginatedSleepResponse> GetSleepCollectionAsync(
            int? limit = default,
            global::System.DateTime? start = default,
            global::System.DateTime? end = default,
            string? nextToken = default,
            global::Whoop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}