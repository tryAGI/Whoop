
#nullable enable

namespace Whoop
{
    /// <summary>
    /// Summary of the sleep stages
    /// </summary>
    public sealed partial class SleepStageSummary
    {
        /// <summary>
        /// Total time the user spent in bed, in milliseconds<br/>
        /// Example: 30272735
        /// </summary>
        /// <example>30272735</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_in_bed_time_milli")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalInBedTimeMilli { get; set; }

        /// <summary>
        /// Total time the user spent awake, in milliseconds<br/>
        /// Example: 1403507
        /// </summary>
        /// <example>1403507</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_awake_time_milli")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalAwakeTimeMilli { get; set; }

        /// <summary>
        /// Total time WHOOP did not receive data from the user during the sleep, in milliseconds<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_no_data_time_milli")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalNoDataTimeMilli { get; set; }

        /// <summary>
        /// Total time the user spent in light sleep, in milliseconds<br/>
        /// Example: 14905851
        /// </summary>
        /// <example>14905851</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_light_sleep_time_milli")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalLightSleepTimeMilli { get; set; }

        /// <summary>
        /// Total time the user spent in Slow Wave Sleep (SWS), in milliseconds<br/>
        /// Example: 6630370
        /// </summary>
        /// <example>6630370</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_slow_wave_sleep_time_milli")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalSlowWaveSleepTimeMilli { get; set; }

        /// <summary>
        /// Total time the user spent in Rapid Eye Movement (REM) sleep, in milliseconds<br/>
        /// Example: 5879573
        /// </summary>
        /// <example>5879573</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_rem_sleep_time_milli")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalRemSleepTimeMilli { get; set; }

        /// <summary>
        /// Number of sleep cycles during the user's sleep<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_cycle_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SleepCycleCount { get; set; }

        /// <summary>
        /// Number of times the user was disturbed during sleep<br/>
        /// Example: 12
        /// </summary>
        /// <example>12</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("disturbance_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DisturbanceCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SleepStageSummary" /> class.
        /// </summary>
        /// <param name="totalInBedTimeMilli">
        /// Total time the user spent in bed, in milliseconds<br/>
        /// Example: 30272735
        /// </param>
        /// <param name="totalAwakeTimeMilli">
        /// Total time the user spent awake, in milliseconds<br/>
        /// Example: 1403507
        /// </param>
        /// <param name="totalNoDataTimeMilli">
        /// Total time WHOOP did not receive data from the user during the sleep, in milliseconds<br/>
        /// Example: 0
        /// </param>
        /// <param name="totalLightSleepTimeMilli">
        /// Total time the user spent in light sleep, in milliseconds<br/>
        /// Example: 14905851
        /// </param>
        /// <param name="totalSlowWaveSleepTimeMilli">
        /// Total time the user spent in Slow Wave Sleep (SWS), in milliseconds<br/>
        /// Example: 6630370
        /// </param>
        /// <param name="totalRemSleepTimeMilli">
        /// Total time the user spent in Rapid Eye Movement (REM) sleep, in milliseconds<br/>
        /// Example: 5879573
        /// </param>
        /// <param name="sleepCycleCount">
        /// Number of sleep cycles during the user's sleep<br/>
        /// Example: 3
        /// </param>
        /// <param name="disturbanceCount">
        /// Number of times the user was disturbed during sleep<br/>
        /// Example: 12
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SleepStageSummary(
            int totalInBedTimeMilli,
            int totalAwakeTimeMilli,
            int totalNoDataTimeMilli,
            int totalLightSleepTimeMilli,
            int totalSlowWaveSleepTimeMilli,
            int totalRemSleepTimeMilli,
            int sleepCycleCount,
            int disturbanceCount)
        {
            this.TotalInBedTimeMilli = totalInBedTimeMilli;
            this.TotalAwakeTimeMilli = totalAwakeTimeMilli;
            this.TotalNoDataTimeMilli = totalNoDataTimeMilli;
            this.TotalLightSleepTimeMilli = totalLightSleepTimeMilli;
            this.TotalSlowWaveSleepTimeMilli = totalSlowWaveSleepTimeMilli;
            this.TotalRemSleepTimeMilli = totalRemSleepTimeMilli;
            this.SleepCycleCount = sleepCycleCount;
            this.DisturbanceCount = disturbanceCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SleepStageSummary" /> class.
        /// </summary>
        public SleepStageSummary()
        {
        }
    }
}