#nullable enable

namespace Whoop
{
    public partial interface IPartnerClient
    {
        /// <summary>
        /// Generate test data for partner development<br/>
        /// Generates a test user and a lab requisition with a booked appointment for partner integration testing. Fetch it with GET /v2/partner/requisition/{id}. Only available in non-production environments.
        /// </summary>
        /// <param name="appointmentType">
        /// Default Value: IN_PERSON
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Whoop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Whoop.TestDataCreateResponse> AddTestDataAsync(
            global::Whoop.AddTestDataAppointmentType? appointmentType = default,
            global::Whoop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate test data for partner development<br/>
        /// Generates a test user and a lab requisition with a booked appointment for partner integration testing. Fetch it with GET /v2/partner/requisition/{id}. Only available in non-production environments.
        /// </summary>
        /// <param name="appointmentType">
        /// Default Value: IN_PERSON
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Whoop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Whoop.AutoSDKHttpResponse<global::Whoop.TestDataCreateResponse>> AddTestDataAsResponseAsync(
            global::Whoop.AddTestDataAppointmentType? appointmentType = default,
            global::Whoop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}