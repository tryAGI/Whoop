
#nullable enable

namespace Whoop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActivityIdMappingResponse
    {
        /// <summary>
        /// V2 Unique identifier for the activity<br/>
        /// Example: ecfc6a15-4661-442f-a9a4-f160dd7afae8
        /// </summary>
        /// <example>ecfc6a15-4661-442f-a9a4-f160dd7afae8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("v2_activity_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid V2ActivityId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityIdMappingResponse" /> class.
        /// </summary>
        /// <param name="v2ActivityId">
        /// V2 Unique identifier for the activity<br/>
        /// Example: ecfc6a15-4661-442f-a9a4-f160dd7afae8
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivityIdMappingResponse(
            global::System.Guid v2ActivityId)
        {
            this.V2ActivityId = v2ActivityId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityIdMappingResponse" /> class.
        /// </summary>
        public ActivityIdMappingResponse()
        {
        }
    }
}