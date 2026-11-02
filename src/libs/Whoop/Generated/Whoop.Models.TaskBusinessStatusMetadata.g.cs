
#nullable enable

namespace Whoop
{
    /// <summary>
    /// Optional data that comes with the task business status. With APPOINTMENT_SCHEDULED, may include the booking_code of the confirmed booking
    /// </summary>
    public sealed partial class TaskBusinessStatusMetadata
    {
        /// <summary>
        /// The partner's booking code, read when the task business status is APPOINTMENT_SCHEDULED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("booking_code")]
        public string? BookingCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskBusinessStatusMetadata" /> class.
        /// </summary>
        /// <param name="bookingCode">
        /// The partner's booking code, read when the task business status is APPOINTMENT_SCHEDULED
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskBusinessStatusMetadata(
            string? bookingCode)
        {
            this.BookingCode = bookingCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskBusinessStatusMetadata" /> class.
        /// </summary>
        public TaskBusinessStatusMetadata()
        {
        }

    }
}