
#nullable enable

namespace Whoop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServiceRequest
    {
        /// <summary>
        /// Unique identifier for the service request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// FHIR status of the service request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// FHIR intent of the service request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Intent { get; set; }

        /// <summary>
        /// Code identifying the specific service or procedure requested
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Task business status for workflow tracking (e.g., 'Specimen collected', 'Results pending')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_business_status")]
        public string? TaskBusinessStatus { get; set; }

        /// <summary>
        /// Task description - free text explanation of what needs to be performed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_description")]
        public string? TaskDescription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceRequest" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the service request
        /// </param>
        /// <param name="status">
        /// FHIR status of the service request
        /// </param>
        /// <param name="intent">
        /// FHIR intent of the service request
        /// </param>
        /// <param name="code">
        /// Code identifying the specific service or procedure requested
        /// </param>
        /// <param name="taskBusinessStatus">
        /// Task business status for workflow tracking (e.g., 'Specimen collected', 'Results pending')
        /// </param>
        /// <param name="taskDescription">
        /// Task description - free text explanation of what needs to be performed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServiceRequest(
            global::System.Guid id,
            string status,
            string intent,
            string code,
            string? taskBusinessStatus,
            string? taskDescription)
        {
            this.Id = id;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Intent = intent ?? throw new global::System.ArgumentNullException(nameof(intent));
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.TaskBusinessStatus = taskBusinessStatus;
            this.TaskDescription = taskDescription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceRequest" /> class.
        /// </summary>
        public ServiceRequest()
        {
        }
    }
}