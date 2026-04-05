
#nullable enable

namespace Whoop
{
    /// <summary>
    /// Breakdown of time spent in each heart rate zone during the workout.
    /// </summary>
    public sealed partial class ZoneDurations
    {
        /// <summary>
        /// Duration in milliseconds spent in Zone 0 (very light activity)<br/>
        /// Example: 300000
        /// </summary>
        /// <example>300000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("zone_zero_milli")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ZoneZeroMilli { get; set; }

        /// <summary>
        /// Duration in milliseconds spent in Zone 1 (light activity)<br/>
        /// Example: 600000
        /// </summary>
        /// <example>600000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("zone_one_milli")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ZoneOneMilli { get; set; }

        /// <summary>
        /// Duration in milliseconds spent in Zone 2 (moderate activity)<br/>
        /// Example: 900000
        /// </summary>
        /// <example>900000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("zone_two_milli")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ZoneTwoMilli { get; set; }

        /// <summary>
        /// Duration in milliseconds spent in Zone 3 (hard activity)<br/>
        /// Example: 900000
        /// </summary>
        /// <example>900000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("zone_three_milli")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ZoneThreeMilli { get; set; }

        /// <summary>
        /// Duration in milliseconds spent in Zone 4 (very hard activity)<br/>
        /// Example: 600000
        /// </summary>
        /// <example>600000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("zone_four_milli")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ZoneFourMilli { get; set; }

        /// <summary>
        /// Duration in milliseconds spent in Zone 5 (maximum effort)<br/>
        /// Example: 300000
        /// </summary>
        /// <example>300000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("zone_five_milli")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ZoneFiveMilli { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ZoneDurations" /> class.
        /// </summary>
        /// <param name="zoneZeroMilli">
        /// Duration in milliseconds spent in Zone 0 (very light activity)<br/>
        /// Example: 300000
        /// </param>
        /// <param name="zoneOneMilli">
        /// Duration in milliseconds spent in Zone 1 (light activity)<br/>
        /// Example: 600000
        /// </param>
        /// <param name="zoneTwoMilli">
        /// Duration in milliseconds spent in Zone 2 (moderate activity)<br/>
        /// Example: 900000
        /// </param>
        /// <param name="zoneThreeMilli">
        /// Duration in milliseconds spent in Zone 3 (hard activity)<br/>
        /// Example: 900000
        /// </param>
        /// <param name="zoneFourMilli">
        /// Duration in milliseconds spent in Zone 4 (very hard activity)<br/>
        /// Example: 600000
        /// </param>
        /// <param name="zoneFiveMilli">
        /// Duration in milliseconds spent in Zone 5 (maximum effort)<br/>
        /// Example: 300000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ZoneDurations(
            long zoneZeroMilli,
            long zoneOneMilli,
            long zoneTwoMilli,
            long zoneThreeMilli,
            long zoneFourMilli,
            long zoneFiveMilli)
        {
            this.ZoneZeroMilli = zoneZeroMilli;
            this.ZoneOneMilli = zoneOneMilli;
            this.ZoneTwoMilli = zoneTwoMilli;
            this.ZoneThreeMilli = zoneThreeMilli;
            this.ZoneFourMilli = zoneFourMilli;
            this.ZoneFiveMilli = zoneFiveMilli;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZoneDurations" /> class.
        /// </summary>
        public ZoneDurations()
        {
        }
    }
}