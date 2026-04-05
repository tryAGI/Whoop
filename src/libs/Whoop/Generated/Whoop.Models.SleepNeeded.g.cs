
#nullable enable

namespace Whoop
{
    /// <summary>
    /// Breakdown of the amount of sleep a user needed before the sleep activity. Summing all individual components results in the amount of sleep the user needed prior to this sleep activity
    /// </summary>
    public sealed partial class SleepNeeded
    {
        /// <summary>
        /// The amount of sleep a user needed based on historical trends<br/>
        /// Example: 27395716
        /// </summary>
        /// <example>27395716</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseline_milli")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long BaselineMilli { get; set; }

        /// <summary>
        /// The difference between the amount of sleep the user's body required and the amount the user actually got<br/>
        /// Example: 352230
        /// </summary>
        /// <example>352230</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("need_from_sleep_debt_milli")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long NeedFromSleepDebtMilli { get; set; }

        /// <summary>
        /// Additional sleep need accrued based on the user's strain<br/>
        /// Example: 208595
        /// </summary>
        /// <example>208595</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("need_from_recent_strain_milli")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long NeedFromRecentStrainMilli { get; set; }

        /// <summary>
        /// Reduction in sleep need accrued based on the user's recent nap activity (negative value or zero)<br/>
        /// Example: -12312
        /// </summary>
        /// <example>-12312</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("need_from_recent_nap_milli")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long NeedFromRecentNapMilli { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SleepNeeded" /> class.
        /// </summary>
        /// <param name="baselineMilli">
        /// The amount of sleep a user needed based on historical trends<br/>
        /// Example: 27395716
        /// </param>
        /// <param name="needFromSleepDebtMilli">
        /// The difference between the amount of sleep the user's body required and the amount the user actually got<br/>
        /// Example: 352230
        /// </param>
        /// <param name="needFromRecentStrainMilli">
        /// Additional sleep need accrued based on the user's strain<br/>
        /// Example: 208595
        /// </param>
        /// <param name="needFromRecentNapMilli">
        /// Reduction in sleep need accrued based on the user's recent nap activity (negative value or zero)<br/>
        /// Example: -12312
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SleepNeeded(
            long baselineMilli,
            long needFromSleepDebtMilli,
            long needFromRecentStrainMilli,
            long needFromRecentNapMilli)
        {
            this.BaselineMilli = baselineMilli;
            this.NeedFromSleepDebtMilli = needFromSleepDebtMilli;
            this.NeedFromRecentStrainMilli = needFromRecentStrainMilli;
            this.NeedFromRecentNapMilli = needFromRecentNapMilli;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SleepNeeded" /> class.
        /// </summary>
        public SleepNeeded()
        {
        }
    }
}