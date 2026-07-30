
#nullable enable

namespace Whoop
{
    /// <summary>
    /// Appointment information
    /// </summary>
    public sealed partial class Appointment
    {
        /// <summary>
        /// The start time of the appointment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTime { get; set; }

        /// <summary>
        /// The service request IDs associated with this appointment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_request_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> ServiceRequestIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Appointment" /> class.
        /// </summary>
        /// <param name="startTime">
        /// The start time of the appointment
        /// </param>
        /// <param name="serviceRequestIds">
        /// The service request IDs associated with this appointment
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Appointment(
            global::System.DateTime startTime,
            global::System.Collections.Generic.IList<global::System.Guid> serviceRequestIds)
        {
            this.StartTime = startTime;
            this.ServiceRequestIds = serviceRequestIds ?? throw new global::System.ArgumentNullException(nameof(serviceRequestIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Appointment" /> class.
        /// </summary>
        public Appointment()
        {
        }

    }
}