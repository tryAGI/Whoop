
#nullable enable

namespace Whoop
{
    /// <summary>
    /// WHOOP's measurements and evaluation of the cycle. Only present if the score state is `SCORED`
    /// </summary>
    public sealed partial class CycleScore
    {
        /// <summary>
        /// WHOOP metric of the cardiovascular load - the level of strain  on the user's cardiovascular system based on the user's heart rate during the cycle. Strain is scored on a scale from 0 to 21.<br/>
        /// Example: 5.2951527F
        /// </summary>
        /// <example>5.2951527F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("strain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float Strain { get; set; }

        /// <summary>
        /// Kilojoules the user expended during the cycle.<br/>
        /// Example: 8288.297F
        /// </summary>
        /// <example>8288.297F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("kilojoule")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float Kilojoule { get; set; }

        /// <summary>
        /// The user's average heart rate during the cycle.<br/>
        /// Example: 68
        /// </summary>
        /// <example>68</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_heart_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AverageHeartRate { get; set; }

        /// <summary>
        /// The user's max heart rate during the cycle.<br/>
        /// Example: 141
        /// </summary>
        /// <example>141</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_heart_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxHeartRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CycleScore" /> class.
        /// </summary>
        /// <param name="strain">
        /// WHOOP metric of the cardiovascular load - the level of strain  on the user's cardiovascular system based on the user's heart rate during the cycle. Strain is scored on a scale from 0 to 21.<br/>
        /// Example: 5.2951527F
        /// </param>
        /// <param name="kilojoule">
        /// Kilojoules the user expended during the cycle.<br/>
        /// Example: 8288.297F
        /// </param>
        /// <param name="averageHeartRate">
        /// The user's average heart rate during the cycle.<br/>
        /// Example: 68
        /// </param>
        /// <param name="maxHeartRate">
        /// The user's max heart rate during the cycle.<br/>
        /// Example: 141
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CycleScore(
            float strain,
            float kilojoule,
            int averageHeartRate,
            int maxHeartRate)
        {
            this.Strain = strain;
            this.Kilojoule = kilojoule;
            this.AverageHeartRate = averageHeartRate;
            this.MaxHeartRate = maxHeartRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CycleScore" /> class.
        /// </summary>
        public CycleScore()
        {
        }
    }
}