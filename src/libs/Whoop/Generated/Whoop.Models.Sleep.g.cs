
#nullable enable

namespace Whoop
{
    /// <summary>
    /// The collection of records in this page.
    /// </summary>
    public sealed partial class Sleep
    {
        /// <summary>
        /// Unique identifier for the sleep activity<br/>
        /// Example: ecfc6a15-4661-442f-a9a4-f160dd7afae8
        /// </summary>
        /// <example>ecfc6a15-4661-442f-a9a4-f160dd7afae8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Unique identifier for the cycle this sleep belongs to<br/>
        /// Example: 93845
        /// </summary>
        /// <example>93845</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cycle_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long CycleId { get; set; }

        /// <summary>
        /// Previous generation identifier for the activity. Will not exist past 09/01/2025<br/>
        /// Example: 93845
        /// </summary>
        /// <example>93845</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("v1_id")]
        public long? V1Id { get; set; }

        /// <summary>
        /// The WHOOP User who performed the sleep activity<br/>
        /// Example: 10129
        /// </summary>
        /// <example>10129</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long UserId { get; set; }

        /// <summary>
        /// The time the sleep activity was recorded in WHOOP<br/>
        /// Example: 2022-04-24T11:25:44.774Z
        /// </summary>
        /// <example>2022-04-24T11:25:44.774Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The time the sleep activity was last updated in WHOOP<br/>
        /// Example: 2022-04-24T14:25:44.774Z
        /// </summary>
        /// <example>2022-04-24T14:25:44.774Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Start time bound of the sleep<br/>
        /// Example: 2022-04-24T02:25:44.774Z
        /// </summary>
        /// <example>2022-04-24T02:25:44.774Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Start { get; set; }

        /// <summary>
        /// End time bound of the sleep<br/>
        /// Example: 2022-04-24T10:25:44.774Z
        /// </summary>
        /// <example>2022-04-24T10:25:44.774Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime End { get; set; }

        /// <summary>
        /// The user's timezone offset at the time the sleep was recorded. Follows format for Time Zone Designator (TZD) - '+hh:mm', '-hh:mm', or 'Z'.<br/>
        /// Example: -05:00
        /// </summary>
        /// <example>-05:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone_offset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TimezoneOffset { get; set; }

        /// <summary>
        /// If true, this sleep activity was a nap for the user<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nap")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Nap { get; set; }

        /// <summary>
        /// `SCORED` means the sleep activity was scored and the measurement values will be present. `PENDING_SCORE` means WHOOP is currently evaluating the sleep activity. `UNSCORABLE` means this activity could not be scored for some reason - commonly because there is not enough user metric data for the time range.<br/>
        /// Example: SCORED
        /// </summary>
        /// <example>SCORED</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Whoop.JsonConverters.SleepScoreStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Whoop.SleepScoreState ScoreState { get; set; }

        /// <summary>
        /// WHOOP's measurements and evaluation of the sleep activity. Only present if the Sleep State is `SCORED`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public global::Whoop.SleepScore? Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Sleep" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the sleep activity<br/>
        /// Example: ecfc6a15-4661-442f-a9a4-f160dd7afae8
        /// </param>
        /// <param name="cycleId">
        /// Unique identifier for the cycle this sleep belongs to<br/>
        /// Example: 93845
        /// </param>
        /// <param name="userId">
        /// The WHOOP User who performed the sleep activity<br/>
        /// Example: 10129
        /// </param>
        /// <param name="createdAt">
        /// The time the sleep activity was recorded in WHOOP<br/>
        /// Example: 2022-04-24T11:25:44.774Z
        /// </param>
        /// <param name="updatedAt">
        /// The time the sleep activity was last updated in WHOOP<br/>
        /// Example: 2022-04-24T14:25:44.774Z
        /// </param>
        /// <param name="start">
        /// Start time bound of the sleep<br/>
        /// Example: 2022-04-24T02:25:44.774Z
        /// </param>
        /// <param name="end">
        /// End time bound of the sleep<br/>
        /// Example: 2022-04-24T10:25:44.774Z
        /// </param>
        /// <param name="timezoneOffset">
        /// The user's timezone offset at the time the sleep was recorded. Follows format for Time Zone Designator (TZD) - '+hh:mm', '-hh:mm', or 'Z'.<br/>
        /// Example: -05:00
        /// </param>
        /// <param name="nap">
        /// If true, this sleep activity was a nap for the user<br/>
        /// Example: false
        /// </param>
        /// <param name="scoreState">
        /// `SCORED` means the sleep activity was scored and the measurement values will be present. `PENDING_SCORE` means WHOOP is currently evaluating the sleep activity. `UNSCORABLE` means this activity could not be scored for some reason - commonly because there is not enough user metric data for the time range.<br/>
        /// Example: SCORED
        /// </param>
        /// <param name="v1Id">
        /// Previous generation identifier for the activity. Will not exist past 09/01/2025<br/>
        /// Example: 93845
        /// </param>
        /// <param name="score">
        /// WHOOP's measurements and evaluation of the sleep activity. Only present if the Sleep State is `SCORED`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Sleep(
            global::System.Guid id,
            long cycleId,
            long userId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.DateTime start,
            global::System.DateTime end,
            string timezoneOffset,
            bool nap,
            global::Whoop.SleepScoreState scoreState,
            long? v1Id,
            global::Whoop.SleepScore? score)
        {
            this.Id = id;
            this.CycleId = cycleId;
            this.V1Id = v1Id;
            this.UserId = userId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Start = start;
            this.End = end;
            this.TimezoneOffset = timezoneOffset ?? throw new global::System.ArgumentNullException(nameof(timezoneOffset));
            this.Nap = nap;
            this.ScoreState = scoreState;
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sleep" /> class.
        /// </summary>
        public Sleep()
        {
        }
    }
}