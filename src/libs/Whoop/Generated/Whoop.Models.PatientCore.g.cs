
#nullable enable

namespace Whoop
{
    /// <summary>
    /// Patient information
    /// </summary>
    public sealed partial class PatientCore
    {
        /// <summary>
        /// Unique identifier for the patient
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatientCore" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the patient
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatientCore(
            global::System.Guid id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatientCore" /> class.
        /// </summary>
        public PatientCore()
        {
        }
    }
}