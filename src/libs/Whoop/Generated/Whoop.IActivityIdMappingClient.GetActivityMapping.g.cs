#nullable enable

namespace Whoop
{
    public partial interface IActivityIdMappingClient
    {
        /// <summary>
        /// Get V2 UUID for V1 Activity ID<br/>
        /// Lookup the V2 UUID for a given V1 activity ID
        /// </summary>
        /// <param name="activityV1Id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Whoop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Whoop.ActivityIdMappingResponse> GetActivityMappingAsync(
            long activityV1Id,
            global::Whoop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}