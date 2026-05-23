
#nullable enable

namespace Whoop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnilabsAppointment
    {
        /// <summary>
        /// External slot identifier used when booking the appointment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slot_id")]
        public string? SlotId { get; set; }

        /// <summary>
        /// The collection address for this appointment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection_address")]
        public global::Whoop.UnilabsCollectionAddress? CollectionAddress { get; set; }

        /// <summary>
        /// The service request IDs associated with this appointment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_request_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> ServiceRequestIds { get; set; }

        /// <summary>
        /// The start time of the appointment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnilabsAppointment" /> class.
        /// </summary>
        /// <param name="serviceRequestIds">
        /// The service request IDs associated with this appointment
        /// </param>
        /// <param name="startTime">
        /// The start time of the appointment
        /// </param>
        /// <param name="slotId">
        /// External slot identifier used when booking the appointment
        /// </param>
        /// <param name="collectionAddress">
        /// The collection address for this appointment
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnilabsAppointment(
            global::System.Collections.Generic.IList<global::System.Guid> serviceRequestIds,
            global::System.DateTime startTime,
            string? slotId,
            global::Whoop.UnilabsCollectionAddress? collectionAddress)
        {
            this.SlotId = slotId;
            this.CollectionAddress = collectionAddress;
            this.ServiceRequestIds = serviceRequestIds ?? throw new global::System.ArgumentNullException(nameof(serviceRequestIds));
            this.StartTime = startTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnilabsAppointment" /> class.
        /// </summary>
        public UnilabsAppointment()
        {
        }

    }
}