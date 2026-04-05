
#nullable enable

namespace Whoop
{
    /// <summary>
    /// The collection of records in this page.
    /// </summary>
    public sealed partial class Cycle
    {
        /// <summary>
        /// Unique identifier for the physiological cycle<br/>
        /// Example: 93845
        /// </summary>
        /// <example>93845</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// The WHOOP User for the physiological cycle<br/>
        /// Example: 10129
        /// </summary>
        /// <example>10129</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long UserId { get; set; }

        /// <summary>
        /// The time the cycle was recorded in WHOOP<br/>
        /// Example: 2022-04-24T11:25:44.774Z
        /// </summary>
        /// <example>2022-04-24T11:25:44.774Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The time the cycle was last updated in WHOOP<br/>
        /// Example: 2022-04-24T14:25:44.774Z
        /// </summary>
        /// <example>2022-04-24T14:25:44.774Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Start time bound of the cycle<br/>
        /// Example: 2022-04-24T02:25:44.774Z
        /// </summary>
        /// <example>2022-04-24T02:25:44.774Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Start { get; set; }

        /// <summary>
        /// End time bound of the cycle. If not present, the user is currently in this cycle<br/>
        /// Example: 2022-04-24T10:25:44.774Z
        /// </summary>
        /// <example>2022-04-24T10:25:44.774Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public global::System.DateTime? End { get; set; }

        /// <summary>
        /// The user's timezone offset at the time the cycle was recorded. Follows format for Time Zone Designator (TZD) - '+hh:mm', '-hh:mm', or 'Z'.<br/>
        /// Example: -05:00
        /// </summary>
        /// <example>-05:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone_offset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TimezoneOffset { get; set; }

        /// <summary>
        /// `SCORED` means the cycle was scored and the measurement values will be present. `PENDING_SCORE` means WHOOP is currently evaluating the cycle. `UNSCORABLE` means this activity could not be scored for some reason - commonly because there is not enough user metric data for the time range.<br/>
        /// Example: SCORED
        /// </summary>
        /// <example>SCORED</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Whoop.JsonConverters.CycleScoreStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Whoop.CycleScoreState ScoreState { get; set; }

        /// <summary>
        /// WHOOP's measurements and evaluation of the cycle. Only present if the score state is `SCORED`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public global::Whoop.CycleScore? Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Cycle" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the physiological cycle<br/>
        /// Example: 93845
        /// </param>
        /// <param name="userId">
        /// The WHOOP User for the physiological cycle<br/>
        /// Example: 10129
        /// </param>
        /// <param name="createdAt">
        /// The time the cycle was recorded in WHOOP<br/>
        /// Example: 2022-04-24T11:25:44.774Z
        /// </param>
        /// <param name="updatedAt">
        /// The time the cycle was last updated in WHOOP<br/>
        /// Example: 2022-04-24T14:25:44.774Z
        /// </param>
        /// <param name="start">
        /// Start time bound of the cycle<br/>
        /// Example: 2022-04-24T02:25:44.774Z
        /// </param>
        /// <param name="timezoneOffset">
        /// The user's timezone offset at the time the cycle was recorded. Follows format for Time Zone Designator (TZD) - '+hh:mm', '-hh:mm', or 'Z'.<br/>
        /// Example: -05:00
        /// </param>
        /// <param name="scoreState">
        /// `SCORED` means the cycle was scored and the measurement values will be present. `PENDING_SCORE` means WHOOP is currently evaluating the cycle. `UNSCORABLE` means this activity could not be scored for some reason - commonly because there is not enough user metric data for the time range.<br/>
        /// Example: SCORED
        /// </param>
        /// <param name="end">
        /// End time bound of the cycle. If not present, the user is currently in this cycle<br/>
        /// Example: 2022-04-24T10:25:44.774Z
        /// </param>
        /// <param name="score">
        /// WHOOP's measurements and evaluation of the cycle. Only present if the score state is `SCORED`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Cycle(
            long id,
            long userId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.DateTime start,
            string timezoneOffset,
            global::Whoop.CycleScoreState scoreState,
            global::System.DateTime? end,
            global::Whoop.CycleScore? score)
        {
            this.Id = id;
            this.UserId = userId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Start = start;
            this.End = end;
            this.TimezoneOffset = timezoneOffset ?? throw new global::System.ArgumentNullException(nameof(timezoneOffset));
            this.ScoreState = scoreState;
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Cycle" /> class.
        /// </summary>
        public Cycle()
        {
        }
    }
}