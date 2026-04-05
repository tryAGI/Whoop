
#nullable enable

namespace Whoop
{
    /// <summary>
    /// WHOOP's measurements and evaluation of the sleep activity. Only present if the Sleep State is `SCORED`
    /// </summary>
    public sealed partial class SleepScore
    {
        /// <summary>
        /// Summary of the sleep stages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stage_summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Whoop.SleepStageSummary StageSummary { get; set; }

        /// <summary>
        /// Breakdown of the amount of sleep a user needed before the sleep activity. Summing all individual components results in the amount of sleep the user needed prior to this sleep activity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_needed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Whoop.SleepNeeded SleepNeeded { get; set; }

        /// <summary>
        /// The user's respiratory rate during the sleep.<br/>
        /// Example: 16.113281F
        /// </summary>
        /// <example>16.113281F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("respiratory_rate")]
        public float? RespiratoryRate { get; set; }

        /// <summary>
        /// A percentage (0-100%) of the time a user is asleep over the amount of sleep the user needed. May not be reported if WHOOP does not have enough data about a user yet to calculate Sleep Need.<br/>
        /// Example: 98F
        /// </summary>
        /// <example>98F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_performance_percentage")]
        public float? SleepPerformancePercentage { get; set; }

        /// <summary>
        /// Percentage (0-100%) of how similar this sleep and wake times compared to the previous day. May not be reported if WHOOP does not have enough sleep data about a user yet to understand consistency.<br/>
        /// Example: 90F
        /// </summary>
        /// <example>90F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_consistency_percentage")]
        public float? SleepConsistencyPercentage { get; set; }

        /// <summary>
        /// A percentage (0-100%) of the time you spend in bed that you are actually asleep.<br/>
        /// Example: 91.695335F
        /// </summary>
        /// <example>91.695335F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_efficiency_percentage")]
        public float? SleepEfficiencyPercentage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SleepScore" /> class.
        /// </summary>
        /// <param name="stageSummary">
        /// Summary of the sleep stages
        /// </param>
        /// <param name="sleepNeeded">
        /// Breakdown of the amount of sleep a user needed before the sleep activity. Summing all individual components results in the amount of sleep the user needed prior to this sleep activity
        /// </param>
        /// <param name="respiratoryRate">
        /// The user's respiratory rate during the sleep.<br/>
        /// Example: 16.113281F
        /// </param>
        /// <param name="sleepPerformancePercentage">
        /// A percentage (0-100%) of the time a user is asleep over the amount of sleep the user needed. May not be reported if WHOOP does not have enough data about a user yet to calculate Sleep Need.<br/>
        /// Example: 98F
        /// </param>
        /// <param name="sleepConsistencyPercentage">
        /// Percentage (0-100%) of how similar this sleep and wake times compared to the previous day. May not be reported if WHOOP does not have enough sleep data about a user yet to understand consistency.<br/>
        /// Example: 90F
        /// </param>
        /// <param name="sleepEfficiencyPercentage">
        /// A percentage (0-100%) of the time you spend in bed that you are actually asleep.<br/>
        /// Example: 91.695335F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SleepScore(
            global::Whoop.SleepStageSummary stageSummary,
            global::Whoop.SleepNeeded sleepNeeded,
            float? respiratoryRate,
            float? sleepPerformancePercentage,
            float? sleepConsistencyPercentage,
            float? sleepEfficiencyPercentage)
        {
            this.StageSummary = stageSummary ?? throw new global::System.ArgumentNullException(nameof(stageSummary));
            this.SleepNeeded = sleepNeeded ?? throw new global::System.ArgumentNullException(nameof(sleepNeeded));
            this.RespiratoryRate = respiratoryRate;
            this.SleepPerformancePercentage = sleepPerformancePercentage;
            this.SleepConsistencyPercentage = sleepConsistencyPercentage;
            this.SleepEfficiencyPercentage = sleepEfficiencyPercentage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SleepScore" /> class.
        /// </summary>
        public SleepScore()
        {
        }
    }
}