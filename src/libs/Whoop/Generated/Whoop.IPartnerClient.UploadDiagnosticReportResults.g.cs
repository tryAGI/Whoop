#nullable enable

namespace Whoop
{
    public partial interface IPartnerClient
    {
        /// <summary>
        /// Create diagnostic report results for a service request<br/>
        /// Creates a diagnostic report with results for a service request. The requesting partner must be an owner of the service request.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Whoop.ApiException"></exception>
        global::System.Threading.Tasks.Task UploadDiagnosticReportResultsAsync(
            global::System.Guid id,

            global::Whoop.DiagnosticReportCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create diagnostic report results for a service request<br/>
        /// Creates a diagnostic report with results for a service request. The requesting partner must be an owner of the service request.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status">
        /// the status of the diagnostic report
        /// </param>
        /// <param name="observations">
        /// optional list of observations to attach to the diagnostic report
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UploadDiagnosticReportResultsAsync(
            global::System.Guid id,
            string? status = default,
            global::System.Collections.Generic.IList<global::Whoop.CreateObservationRequest>? observations = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}