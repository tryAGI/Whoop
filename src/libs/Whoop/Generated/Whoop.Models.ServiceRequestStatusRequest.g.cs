
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
        /// Optional data that comes with the task business status. With APPOINTMENT_SCHEDULED, may include the booking_code of the confirmed booking
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Whoop.TaskBusinessStatusMetadata? Metadata { get; set; }

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
        /// <param name="metadata">
        /// Optional data that comes with the task business status. With APPOINTMENT_SCHEDULED, may include the booking_code of the confirmed booking
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServiceRequestStatusRequest(
            string? taskBusinessStatus,
            string? reason,
            global::Whoop.TaskBusinessStatusMetadata? metadata)
        {
            this.TaskBusinessStatus = taskBusinessStatus;
            this.Reason = reason;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceRequestStatusRequest" /> class.
        /// </summary>
        public ServiceRequestStatusRequest()
        {
        }

    }
}