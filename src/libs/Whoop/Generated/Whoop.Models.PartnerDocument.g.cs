
#nullable enable

namespace Whoop
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PartnerDocument
    {
        /// <summary>
        /// Unique identifier for the document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The type of document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DocumentType { get; set; }

        /// <summary>
        /// Optional externally accessible URL where the document can be retrieved
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Timestamp when the document was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the document was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Optional bundle identifier for grouping related documents
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bundle_id")]
        public global::System.Guid? BundleId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartnerDocument" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the document
        /// </param>
        /// <param name="documentType">
        /// The type of document
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the document was created
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the document was last updated
        /// </param>
        /// <param name="url">
        /// Optional externally accessible URL where the document can be retrieved
        /// </param>
        /// <param name="bundleId">
        /// Optional bundle identifier for grouping related documents
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartnerDocument(
            global::System.Guid id,
            string documentType,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? url,
            global::System.Guid? bundleId)
        {
            this.Id = id;
            this.DocumentType = documentType ?? throw new global::System.ArgumentNullException(nameof(documentType));
            this.Url = url;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.BundleId = bundleId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartnerDocument" /> class.
        /// </summary>
        public PartnerDocument()
        {
        }

    }
}