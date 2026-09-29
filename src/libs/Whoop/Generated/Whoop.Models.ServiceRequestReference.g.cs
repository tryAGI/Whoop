
#nullable enable

namespace Whoop
{
    /// <summary>
    /// List of FHIR resources this service request is based on
    /// </summary>
    public sealed partial class ServiceRequestReference
    {
        /// <summary>
        /// The FHIR resource type of the referenced resource
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// The unique identifier of the referenced resource
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
        /// Initializes a new instance of the <see cref="ServiceRequestReference" /> class.
        /// </summary>
        /// <param name="type">
        /// The FHIR resource type of the referenced resource
        /// </param>
        /// <param name="id">
        /// The unique identifier of the referenced resource
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServiceRequestReference(
            string type,
            global::System.Guid id)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceRequestReference" /> class.
        /// </summary>
        public ServiceRequestReference()
        {
        }

    }
}