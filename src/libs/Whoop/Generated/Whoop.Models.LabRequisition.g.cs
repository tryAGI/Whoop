
#nullable enable

namespace Whoop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LabRequisition
    {
        /// <summary>
        /// Unique identifier for the lab requisition
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Timestamp when the lab requisition was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the lab requisition was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The service requests associated with this lab requisition
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Whoop.ServiceRequest> ServiceRequests { get; set; }

        /// <summary>
        /// Patient information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patient")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Whoop.PatientCore Patient { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabRequisition" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the lab requisition
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the lab requisition was created
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the lab requisition was last updated
        /// </param>
        /// <param name="serviceRequests">
        /// The service requests associated with this lab requisition
        /// </param>
        /// <param name="patient">
        /// Patient information
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabRequisition(
            global::System.Guid id,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.Collections.Generic.IList<global::Whoop.ServiceRequest> serviceRequests,
            global::Whoop.PatientCore patient)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ServiceRequests = serviceRequests ?? throw new global::System.ArgumentNullException(nameof(serviceRequests));
            this.Patient = patient ?? throw new global::System.ArgumentNullException(nameof(patient));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabRequisition" /> class.
        /// </summary>
        public LabRequisition()
        {
        }
    }
}