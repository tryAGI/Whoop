#nullable enable

namespace Whoop
{
    public partial interface IPartnerClient
    {
        /// <summary>
        /// Generate test data for partner development<br/>
        /// Generates test user and lab requisition data for partner integration testing. This endpoint is only available in non-production environments
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Whoop.ApiException"></exception>
        global::System.Threading.Tasks.Task AddTestDataAsync(
            global::Whoop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate test data for partner development<br/>
        /// Generates test user and lab requisition data for partner integration testing. This endpoint is only available in non-production environments
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Whoop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Whoop.AutoSDKHttpResponse> AddTestDataAsResponseAsync(
            global::Whoop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}