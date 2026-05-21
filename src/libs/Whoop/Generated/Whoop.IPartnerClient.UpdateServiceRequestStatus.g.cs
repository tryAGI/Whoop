#nullable enable

namespace Whoop
{
    public partial interface IPartnerClient
    {
        /// <summary>
        /// Update service request status<br/>
        /// Updates the business status of a service request task. The requesting partner must be an owner of the service request.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Whoop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Whoop.ServiceRequest> UpdateServiceRequestStatusAsync(
            global::System.Guid id,

            global::Whoop.ServiceRequestStatusRequest request,
            global::Whoop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update service request status<br/>
        /// Updates the business status of a service request task. The requesting partner must be an owner of the service request.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Whoop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Whoop.AutoSDKHttpResponse<global::Whoop.ServiceRequest>> UpdateServiceRequestStatusAsResponseAsync(
            global::System.Guid id,

            global::Whoop.ServiceRequestStatusRequest request,
            global::Whoop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update service request status<br/>
        /// Updates the business status of a service request task. The requesting partner must be an owner of the service request.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="taskBusinessStatus">
        /// Task business status for workflow tracking (e.g., 'Specimen collected', 'Results pending')
        /// </param>
        /// <param name="reason">
        /// Optional reason for the task business status change
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Whoop.ServiceRequest> UpdateServiceRequestStatusAsync(
            global::System.Guid id,
            string? taskBusinessStatus = default,
            string? reason = default,
            global::Whoop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}