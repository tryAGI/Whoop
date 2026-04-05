
#nullable enable

namespace Whoop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserBodyMeasurement
    {
        /// <summary>
        /// User's height in meters<br/>
        /// Example: 1.8288F
        /// </summary>
        /// <example>1.8288F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("height_meter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float HeightMeter { get; set; }

        /// <summary>
        /// User's weight in kilograms<br/>
        /// Example: 90.7185F
        /// </summary>
        /// <example>90.7185F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight_kilogram")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float WeightKilogram { get; set; }

        /// <summary>
        /// The max heart rate WHOOP calculated for the user<br/>
        /// Example: 200
        /// </summary>
        /// <example>200</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_heart_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxHeartRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserBodyMeasurement" /> class.
        /// </summary>
        /// <param name="heightMeter">
        /// User's height in meters<br/>
        /// Example: 1.8288F
        /// </param>
        /// <param name="weightKilogram">
        /// User's weight in kilograms<br/>
        /// Example: 90.7185F
        /// </param>
        /// <param name="maxHeartRate">
        /// The max heart rate WHOOP calculated for the user<br/>
        /// Example: 200
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserBodyMeasurement(
            float heightMeter,
            float weightKilogram,
            int maxHeartRate)
        {
            this.HeightMeter = heightMeter;
            this.WeightKilogram = weightKilogram;
            this.MaxHeartRate = maxHeartRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserBodyMeasurement" /> class.
        /// </summary>
        public UserBodyMeasurement()
        {
        }
    }
}