
#nullable enable

namespace Whoop
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TestDataCreateResponse
    {
        /// <summary>
        /// the id of the created lab requisition
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requisition_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RequisitionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestDataCreateResponse" /> class.
        /// </summary>
        /// <param name="requisitionId">
        /// the id of the created lab requisition
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestDataCreateResponse(
            global::System.Guid requisitionId)
        {
            this.RequisitionId = requisitionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestDataCreateResponse" /> class.
        /// </summary>
        public TestDataCreateResponse()
        {
        }

    }
}