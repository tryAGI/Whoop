
#nullable enable

namespace Whoop
{
    /// <summary>
    /// Paginated collection of recovery activities with next token for pagination
    /// </summary>
    public sealed partial class RecoveryCollection
    {
        /// <summary>
        /// The collection of records in this page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("records")]
        public global::System.Collections.Generic.IList<global::Whoop.Recovery>? Records { get; set; }

        /// <summary>
        /// A token that can be used on the next request to access the next page of records. If the token is not present, there are no more records in the collection.<br/>
        /// Example: MTIzOjEyMzEyMw
        /// </summary>
        /// <example>MTIzOjEyMzEyMw</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_token")]
        public string? NextToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecoveryCollection" /> class.
        /// </summary>
        /// <param name="records">
        /// The collection of records in this page.
        /// </param>
        /// <param name="nextToken">
        /// A token that can be used on the next request to access the next page of records. If the token is not present, there are no more records in the collection.<br/>
        /// Example: MTIzOjEyMzEyMw
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecoveryCollection(
            global::System.Collections.Generic.IList<global::Whoop.Recovery>? records,
            string? nextToken)
        {
            this.Records = records;
            this.NextToken = nextToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecoveryCollection" /> class.
        /// </summary>
        public RecoveryCollection()
        {
        }
    }
}