#nullable enable

namespace Whoop
{
    public partial interface IPartnerClient
    {
        /// <summary>
        /// Get a service request by ID<br/>
        /// Retrieves a service request by its unique identifier. The requesting partner must be an owner of the service request.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Whoop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Whoop.ServiceRequest> GetServiceRequestByIdAsync(
            global::System.Guid id,
            global::Whoop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a service request by ID<br/>
        /// Retrieves a service request by its unique identifier. The requesting partner must be an owner of the service request.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Whoop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Whoop.AutoSDKHttpResponse<global::Whoop.ServiceRequest>> GetServiceRequestByIdAsResponseAsync(
            global::System.Guid id,
            global::Whoop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}