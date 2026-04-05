
#nullable enable

namespace Whoop
{
    /// <summary>
    /// `SCORED` means the workout activity was scored and the measurement values will be present. `PENDING_SCORE` means WHOOP is currently evaluating the workout activity. `UNSCORABLE` means this activity could not be scored for some reason - commonly because there is not enough user metric data for the time range.<br/>
    /// Example: SCORED
    /// </summary>
    public enum WorkoutV2ScoreState
    {
        /// <summary>
        /// 
        /// </summary>
        PendingScore,
        /// <summary>
        /// 
        /// </summary>
        Scored,
        /// <summary>
        /// 
        /// </summary>
        Unscorable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkoutV2ScoreStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkoutV2ScoreState value)
        {
            return value switch
            {
                WorkoutV2ScoreState.PendingScore => "PENDING_SCORE",
                WorkoutV2ScoreState.Scored => "SCORED",
                WorkoutV2ScoreState.Unscorable => "UNSCORABLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkoutV2ScoreState? ToEnum(string value)
        {
            return value switch
            {
                "PENDING_SCORE" => WorkoutV2ScoreState.PendingScore,
                "SCORED" => WorkoutV2ScoreState.Scored,
                "UNSCORABLE" => WorkoutV2ScoreState.Unscorable,
                _ => null,
            };
        }
    }
}