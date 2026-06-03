
#nullable enable

namespace Whoop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SleepStreamDataPoint
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public global::System.DateTime? Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hr")]
        public int? Hr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skin_temp")]
        public float? SkinTemp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("board_temp")]
        public float? BoardTemp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("battery_temp")]
        public float? BatteryTemp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_sleeping")]
        public bool? IsSleeping { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_charging")]
        public bool? IsCharging { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SleepStreamDataPoint" /> class.
        /// </summary>
        /// <param name="timestamp"></param>
        /// <param name="hr"></param>
        /// <param name="skinTemp"></param>
        /// <param name="boardTemp"></param>
        /// <param name="batteryTemp"></param>
        /// <param name="isSleeping"></param>
        /// <param name="isCharging"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SleepStreamDataPoint(
            global::System.DateTime? timestamp,
            int? hr,
            float? skinTemp,
            float? boardTemp,
            float? batteryTemp,
            bool? isSleeping,
            bool? isCharging)
        {
            this.Timestamp = timestamp;
            this.Hr = hr;
            this.SkinTemp = skinTemp;
            this.BoardTemp = boardTemp;
            this.BatteryTemp = batteryTemp;
            this.IsSleeping = isSleeping;
            this.IsCharging = isCharging;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SleepStreamDataPoint" /> class.
        /// </summary>
        public SleepStreamDataPoint()
        {
        }

    }
}