
#nullable enable

namespace Whoop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Recovery
    {
        /// <summary>
        /// The Recovery represents how recovered the user is for this physiological cycle<br/>
        /// Example: 93845
        /// </summary>
        /// <example>93845</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cycle_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long CycleId { get; set; }

        /// <summary>
        /// ID of the Sleep associated with the Recovery<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </summary>
        /// <example>123e4567-e89b-12d3-a456-426614174000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SleepId { get; set; }

        /// <summary>
        /// The WHOOP User for the recovery<br/>
        /// Example: 10129
        /// </summary>
        /// <example>10129</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long UserId { get; set; }

        /// <summary>
        /// The time the recovery was recorded in WHOOP<br/>
        /// Example: 2022-04-24T11:25:44.774Z
        /// </summary>
        /// <example>2022-04-24T11:25:44.774Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The time the recovery was last updated in WHOOP<br/>
        /// Example: 2022-04-24T14:25:44.774Z
        /// </summary>
        /// <example>2022-04-24T14:25:44.774Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// `SCORED` means the recovery was scored and the measurement values will be present. `PENDING_SCORE` means WHOOP is currently evaluating the cycle. `UNSCORABLE` means this activity could not be scored for some reason - commonly because there is not enough user metric data for the time range.<br/>
        /// Example: SCORED
        /// </summary>
        /// <example>SCORED</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Whoop.JsonConverters.RecoveryScoreStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Whoop.RecoveryScoreState ScoreState { get; set; }

        /// <summary>
        /// WHOOP's measurements and evaluation of the recovery. Only present if the Recovery State is `SCORED`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public global::Whoop.RecoveryScore? Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Recovery" /> class.
        /// </summary>
        /// <param name="cycleId">
        /// The Recovery represents how recovered the user is for this physiological cycle<br/>
        /// Example: 93845
        /// </param>
        /// <param name="sleepId">
        /// ID of the Sleep associated with the Recovery<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="userId">
        /// The WHOOP User for the recovery<br/>
        /// Example: 10129
        /// </param>
        /// <param name="createdAt">
        /// The time the recovery was recorded in WHOOP<br/>
        /// Example: 2022-04-24T11:25:44.774Z
        /// </param>
        /// <param name="updatedAt">
        /// The time the recovery was last updated in WHOOP<br/>
        /// Example: 2022-04-24T14:25:44.774Z
        /// </param>
        /// <param name="scoreState">
        /// `SCORED` means the recovery was scored and the measurement values will be present. `PENDING_SCORE` means WHOOP is currently evaluating the cycle. `UNSCORABLE` means this activity could not be scored for some reason - commonly because there is not enough user metric data for the time range.<br/>
        /// Example: SCORED
        /// </param>
        /// <param name="score">
        /// WHOOP's measurements and evaluation of the recovery. Only present if the Recovery State is `SCORED`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Recovery(
            long cycleId,
            global::System.Guid sleepId,
            long userId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::Whoop.RecoveryScoreState scoreState,
            global::Whoop.RecoveryScore? score)
        {
            this.CycleId = cycleId;
            this.SleepId = sleepId;
            this.UserId = userId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ScoreState = scoreState;
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Recovery" /> class.
        /// </summary>
        public Recovery()
        {
        }
    }
}