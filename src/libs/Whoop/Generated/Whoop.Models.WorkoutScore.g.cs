
#nullable enable

namespace Whoop
{
    /// <summary>
    /// WHOOP's measurements and evaluation of the workout activity. Only present if the Workout State is `SCORED`
    /// </summary>
    public sealed partial class WorkoutScore
    {
        /// <summary>
        /// WHOOP metric of the cardiovascular load - the level of strain the workout had on the user's cardiovascular system based on the user's heart rate. Strain is scored on a scale from 0 to 21.<br/>
        /// Example: 8.2463F
        /// </summary>
        /// <example>8.2463F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("strain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float Strain { get; set; }

        /// <summary>
        /// The user's average heart rate (beats per minute) during the workout.<br/>
        /// Example: 123
        /// </summary>
        /// <example>123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_heart_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AverageHeartRate { get; set; }

        /// <summary>
        /// The user's max heart rate (beats per minute) during the workout.<br/>
        /// Example: 146
        /// </summary>
        /// <example>146</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_heart_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxHeartRate { get; set; }

        /// <summary>
        /// Kilojoules the user expended during the workout.<br/>
        /// Example: 1569.3403F
        /// </summary>
        /// <example>1569.3403F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("kilojoule")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float Kilojoule { get; set; }

        /// <summary>
        /// Percentage (0-100%) of heart rate data WHOOP received during the workout.<br/>
        /// Example: 100F
        /// </summary>
        /// <example>100F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("percent_recorded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float PercentRecorded { get; set; }

        /// <summary>
        /// The distance the user travelled during the workout. Only present if distance data sent to WHOOP<br/>
        /// Example: 1772.7704F
        /// </summary>
        /// <example>1772.7704F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance_meter")]
        public float? DistanceMeter { get; set; }

        /// <summary>
        /// The altitude gained during the workout. This measurement does not account for downward travel - it is strictly a measure of altitude climbed. If a member climbed up and down a 1,000 meter mountain, ending at the same altitude, this measurement would be 1,000 meters. Only present if altitude data is included as part of the workout<br/>
        /// Example: 46.643845F
        /// </summary>
        /// <example>46.643845F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("altitude_gain_meter")]
        public float? AltitudeGainMeter { get; set; }

        /// <summary>
        /// The altitude difference between the start and end points of the workout. If a member climbed up and down a mountain, ending at the same altitude, this measurement would be 0. Only present if altitude data is included as part of the workout<br/>
        /// Example: -0.781372F
        /// </summary>
        /// <example>-0.781372F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("altitude_change_meter")]
        public float? AltitudeChangeMeter { get; set; }

        /// <summary>
        /// Breakdown of time spent in each heart rate zone during the workout.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zone_durations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Whoop.ZoneDurations ZoneDurations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutScore" /> class.
        /// </summary>
        /// <param name="strain">
        /// WHOOP metric of the cardiovascular load - the level of strain the workout had on the user's cardiovascular system based on the user's heart rate. Strain is scored on a scale from 0 to 21.<br/>
        /// Example: 8.2463F
        /// </param>
        /// <param name="averageHeartRate">
        /// The user's average heart rate (beats per minute) during the workout.<br/>
        /// Example: 123
        /// </param>
        /// <param name="maxHeartRate">
        /// The user's max heart rate (beats per minute) during the workout.<br/>
        /// Example: 146
        /// </param>
        /// <param name="kilojoule">
        /// Kilojoules the user expended during the workout.<br/>
        /// Example: 1569.3403F
        /// </param>
        /// <param name="percentRecorded">
        /// Percentage (0-100%) of heart rate data WHOOP received during the workout.<br/>
        /// Example: 100F
        /// </param>
        /// <param name="zoneDurations">
        /// Breakdown of time spent in each heart rate zone during the workout.
        /// </param>
        /// <param name="distanceMeter">
        /// The distance the user travelled during the workout. Only present if distance data sent to WHOOP<br/>
        /// Example: 1772.7704F
        /// </param>
        /// <param name="altitudeGainMeter">
        /// The altitude gained during the workout. This measurement does not account for downward travel - it is strictly a measure of altitude climbed. If a member climbed up and down a 1,000 meter mountain, ending at the same altitude, this measurement would be 1,000 meters. Only present if altitude data is included as part of the workout<br/>
        /// Example: 46.643845F
        /// </param>
        /// <param name="altitudeChangeMeter">
        /// The altitude difference between the start and end points of the workout. If a member climbed up and down a mountain, ending at the same altitude, this measurement would be 0. Only present if altitude data is included as part of the workout<br/>
        /// Example: -0.781372F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkoutScore(
            float strain,
            int averageHeartRate,
            int maxHeartRate,
            float kilojoule,
            float percentRecorded,
            global::Whoop.ZoneDurations zoneDurations,
            float? distanceMeter,
            float? altitudeGainMeter,
            float? altitudeChangeMeter)
        {
            this.Strain = strain;
            this.AverageHeartRate = averageHeartRate;
            this.MaxHeartRate = maxHeartRate;
            this.Kilojoule = kilojoule;
            this.PercentRecorded = percentRecorded;
            this.DistanceMeter = distanceMeter;
            this.AltitudeGainMeter = altitudeGainMeter;
            this.AltitudeChangeMeter = altitudeChangeMeter;
            this.ZoneDurations = zoneDurations ?? throw new global::System.ArgumentNullException(nameof(zoneDurations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutScore" /> class.
        /// </summary>
        public WorkoutScore()
        {
        }
    }
}