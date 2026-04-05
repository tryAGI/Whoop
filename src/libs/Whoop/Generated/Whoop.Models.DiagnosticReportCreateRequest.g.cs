
#nullable enable

namespace Whoop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DiagnosticReportCreateRequest
    {
        /// <summary>
        /// the status of the diagnostic report
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// optional list of observations to attach to the diagnostic report
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("observations")]
        public global::System.Collections.Generic.IList<global::Whoop.CreateObservationRequest>? Observations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticReportCreateRequest" /> class.
        /// </summary>
        /// <param name="status">
        /// the status of the diagnostic report
        /// </param>
        /// <param name="observations">
        /// optional list of observations to attach to the diagnostic report
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DiagnosticReportCreateRequest(
            string? status,
            global::System.Collections.Generic.IList<global::Whoop.CreateObservationRequest>? observations)
        {
            this.Status = status;
            this.Observations = observations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticReportCreateRequest" /> class.
        /// </summary>
        public DiagnosticReportCreateRequest()
        {
        }
    }
}