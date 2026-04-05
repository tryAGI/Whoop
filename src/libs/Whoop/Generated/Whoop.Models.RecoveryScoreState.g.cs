
#nullable enable

namespace Whoop
{
    /// <summary>
    /// `SCORED` means the recovery was scored and the measurement values will be present. `PENDING_SCORE` means WHOOP is currently evaluating the cycle. `UNSCORABLE` means this activity could not be scored for some reason - commonly because there is not enough user metric data for the time range.<br/>
    /// Example: SCORED
    /// </summary>
    public enum RecoveryScoreState
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
    public static class RecoveryScoreStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RecoveryScoreState value)
        {
            return value switch
            {
                RecoveryScoreState.PendingScore => "PENDING_SCORE",
                RecoveryScoreState.Scored => "SCORED",
                RecoveryScoreState.Unscorable => "UNSCORABLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RecoveryScoreState? ToEnum(string value)
        {
            return value switch
            {
                "PENDING_SCORE" => RecoveryScoreState.PendingScore,
                "SCORED" => RecoveryScoreState.Scored,
                "UNSCORABLE" => RecoveryScoreState.Unscorable,
                _ => null,
            };
        }
    }
}