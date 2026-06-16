
#nullable enable

namespace Whoop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SleepStreamResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public global::System.Collections.Generic.IList<global::Whoop.SleepStreamDataPoint>? Stream { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("algorithm_version")]
        public string? AlgorithmVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SleepStreamResponse" /> class.
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="algorithmVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SleepStreamResponse(
            global::System.Collections.Generic.IList<global::Whoop.SleepStreamDataPoint>? stream,
            string? algorithmVersion)
        {
            this.Stream = stream;
            this.AlgorithmVersion = algorithmVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SleepStreamResponse" /> class.
        /// </summary>
        public SleepStreamResponse()
        {
        }

    }
}