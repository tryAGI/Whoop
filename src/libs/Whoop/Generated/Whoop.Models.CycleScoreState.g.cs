
#nullable enable

namespace Whoop
{
    /// <summary>
    /// `SCORED` means the cycle was scored and the measurement values will be present. `PENDING_SCORE` means WHOOP is currently evaluating the cycle. `UNSCORABLE` means this activity could not be scored for some reason - commonly because there is not enough user metric data for the time range.<br/>
    /// Example: SCORED
    /// </summary>
    public enum CycleScoreState
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
    public static class CycleScoreStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CycleScoreState value)
        {
            return value switch
            {
                CycleScoreState.PendingScore => "PENDING_SCORE",
                CycleScoreState.Scored => "SCORED",
                CycleScoreState.Unscorable => "UNSCORABLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CycleScoreState? ToEnum(string value)
        {
            return value switch
            {
                "PENDING_SCORE" => CycleScoreState.PendingScore,
                "SCORED" => CycleScoreState.Scored,
                "UNSCORABLE" => CycleScoreState.Unscorable,
                _ => null,
            };
        }
    }
}