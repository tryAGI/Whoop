
#nullable enable

namespace Whoop
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnilabsAppointmentVariant2
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnilabsAppointmentVariant2" /> class.
        /// </summary>
        /// <param name="slotId">
        /// External slot identifier used when booking the appointment
        /// </param>
        /// <param name="collectionAddress">
        /// The collection address for this appointment
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnilabsAppointmentVariant2(
            string? slotId,
            global::Whoop.UnilabsCollectionAddress? collectionAddress)
        {
            this.SlotId = slotId;
            this.CollectionAddress = collectionAddress;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnilabsAppointmentVariant2" /> class.
        /// </summary>
        public UnilabsAppointmentVariant2()
        {
        }

    }
}