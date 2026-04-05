
#nullable enable

namespace Whoop
{
    /// <summary>
    /// A WHOOP workout activity with full details and scoring information
    /// </summary>
    public sealed partial class WorkoutV2
    {
        /// <summary>
        /// Unique identifier for the workout activity<br/>
        /// Example: ecfc6a15-4661-442f-a9a4-f160dd7afae8
        /// </summary>
        /// <example>ecfc6a15-4661-442f-a9a4-f160dd7afae8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Previous generation identifier for the activity. Will not exist past 09/01/2025<br/>
        /// Example: 1043
        /// </summary>
        /// <example>1043</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("v1_id")]
        public long? V1Id { get; set; }

        /// <summary>
        /// The WHOOP User who performed the workout<br/>
        /// Example: 9012
        /// </summary>
        /// <example>9012</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long UserId { get; set; }

        /// <summary>
        /// The time the workout activity was recorded in WHOOP<br/>
        /// Example: 2022-04-24T11:25:44.774Z
        /// </summary>
        /// <example>2022-04-24T11:25:44.774Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The time the workout activity was last updated in WHOOP<br/>
        /// Example: 2022-04-24T14:25:44.774Z
        /// </summary>
        /// <example>2022-04-24T14:25:44.774Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Start time bound of the workout<br/>
        /// Example: 2022-04-24T02:25:44.774Z
        /// </summary>
        /// <example>2022-04-24T02:25:44.774Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Start { get; set; }

        /// <summary>
        /// End time bound of the workout<br/>
        /// Example: 2022-04-24T10:25:44.774Z
        /// </summary>
        /// <example>2022-04-24T10:25:44.774Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime End { get; set; }

        /// <summary>
        /// The user's timezone offset at the time the workout was recorded. Follows format for Time Zone Designator (TZD) - '+hh:mm', '-hh:mm', or 'Z'.<br/>
        /// Example: -05:00
        /// </summary>
        /// <example>-05:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone_offset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TimezoneOffset { get; set; }

        /// <summary>
        /// Name of the WHOOP Sport performed during the workout<br/>
        /// Example: running
        /// </summary>
        /// <example>running</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sport_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SportName { get; set; }

        /// <summary>
        /// `SCORED` means the workout activity was scored and the measurement values will be present. `PENDING_SCORE` means WHOOP is currently evaluating the workout activity. `UNSCORABLE` means this activity could not be scored for some reason - commonly because there is not enough user metric data for the time range.<br/>
        /// Example: SCORED
        /// </summary>
        /// <example>SCORED</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Whoop.JsonConverters.WorkoutV2ScoreStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Whoop.WorkoutV2ScoreState ScoreState { get; set; }

        /// <summary>
        /// WHOOP's measurements and evaluation of the workout activity. Only present if the Workout State is `SCORED`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public global::Whoop.WorkoutScore? Score { get; set; }

        /// <summary>
        /// ID of the WHOOP Sport performed during the workout. Will not exist past 09/01/2025<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sport_id")]
        public int? SportId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutV2" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the workout activity<br/>
        /// Example: ecfc6a15-4661-442f-a9a4-f160dd7afae8
        /// </param>
        /// <param name="userId">
        /// The WHOOP User who performed the workout<br/>
        /// Example: 9012
        /// </param>
        /// <param name="createdAt">
        /// The time the workout activity was recorded in WHOOP<br/>
        /// Example: 2022-04-24T11:25:44.774Z
        /// </param>
        /// <param name="updatedAt">
        /// The time the workout activity was last updated in WHOOP<br/>
        /// Example: 2022-04-24T14:25:44.774Z
        /// </param>
        /// <param name="start">
        /// Start time bound of the workout<br/>
        /// Example: 2022-04-24T02:25:44.774Z
        /// </param>
        /// <param name="end">
        /// End time bound of the workout<br/>
        /// Example: 2022-04-24T10:25:44.774Z
        /// </param>
        /// <param name="timezoneOffset">
        /// The user's timezone offset at the time the workout was recorded. Follows format for Time Zone Designator (TZD) - '+hh:mm', '-hh:mm', or 'Z'.<br/>
        /// Example: -05:00
        /// </param>
        /// <param name="sportName">
        /// Name of the WHOOP Sport performed during the workout<br/>
        /// Example: running
        /// </param>
        /// <param name="scoreState">
        /// `SCORED` means the workout activity was scored and the measurement values will be present. `PENDING_SCORE` means WHOOP is currently evaluating the workout activity. `UNSCORABLE` means this activity could not be scored for some reason - commonly because there is not enough user metric data for the time range.<br/>
        /// Example: SCORED
        /// </param>
        /// <param name="v1Id">
        /// Previous generation identifier for the activity. Will not exist past 09/01/2025<br/>
        /// Example: 1043
        /// </param>
        /// <param name="score">
        /// WHOOP's measurements and evaluation of the workout activity. Only present if the Workout State is `SCORED`
        /// </param>
        /// <param name="sportId">
        /// ID of the WHOOP Sport performed during the workout. Will not exist past 09/01/2025<br/>
        /// Example: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkoutV2(
            global::System.Guid id,
            long userId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.DateTime start,
            global::System.DateTime end,
            string timezoneOffset,
            string sportName,
            global::Whoop.WorkoutV2ScoreState scoreState,
            long? v1Id,
            global::Whoop.WorkoutScore? score,
            int? sportId)
        {
            this.Id = id;
            this.V1Id = v1Id;
            this.UserId = userId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Start = start;
            this.End = end;
            this.TimezoneOffset = timezoneOffset ?? throw new global::System.ArgumentNullException(nameof(timezoneOffset));
            this.SportName = sportName ?? throw new global::System.ArgumentNullException(nameof(sportName));
            this.ScoreState = scoreState;
            this.Score = score;
            this.SportId = sportId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutV2" /> class.
        /// </summary>
        public WorkoutV2()
        {
        }
    }
}