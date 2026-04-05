
#nullable enable

namespace Whoop
{
    /// <summary>
    /// `SCORED` means the sleep activity was scored and the measurement values will be present. `PENDING_SCORE` means WHOOP is currently evaluating the sleep activity. `UNSCORABLE` means this activity could not be scored for some reason - commonly because there is not enough user metric data for the time range.<br/>
    /// Example: SCORED
    /// </summary>
    public enum SleepScoreState
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
    public static class SleepScoreStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SleepScoreState value)
        {
            return value switch
            {
                SleepScoreState.PendingScore => "PENDING_SCORE",
                SleepScoreState.Scored => "SCORED",
                SleepScoreState.Unscorable => "UNSCORABLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SleepScoreState? ToEnum(string value)
        {
            return value switch
            {
                "PENDING_SCORE" => SleepScoreState.PendingScore,
                "SCORED" => SleepScoreState.Scored,
                "UNSCORABLE" => SleepScoreState.Unscorable,
                _ => null,
            };
        }
    }
}