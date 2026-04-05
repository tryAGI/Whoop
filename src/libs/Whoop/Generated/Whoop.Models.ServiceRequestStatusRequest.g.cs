
#nullable enable

namespace Whoop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServiceRequestStatusRequest
    {
        /// <summary>
        /// Task business status for workflow tracking (e.g., 'Specimen collected', 'Results pending')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_business_status")]
        public string? TaskBusinessStatus { get; set; }

        /// <summary>
        /// Optional reason for the task business status change
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceRequestStatusRequest" /> class.
        /// </summary>
        /// <param name="taskBusinessStatus">
        /// Task business status for workflow tracking (e.g., 'Specimen collected', 'Results pending')
        /// </param>
        /// <param name="reason">
        /// Optional reason for the task business status change
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServiceRequestStatusRequest(
            string? taskBusinessStatus,
            string? reason)
        {
            this.TaskBusinessStatus = taskBusinessStatus;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceRequestStatusRequest" /> class.
        /// </summary>
        public ServiceRequestStatusRequest()
        {
        }
    }
}