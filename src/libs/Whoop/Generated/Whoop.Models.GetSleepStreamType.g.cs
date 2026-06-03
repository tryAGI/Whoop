
#nullable enable

namespace Whoop
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSleepStreamType
    {
        /// <summary>
        /// 
        /// </summary>
        BatteryTemp,
        /// <summary>
        /// 
        /// </summary>
        BoardTemp,
        /// <summary>
        /// 
        /// </summary>
        ChargingStatus,
        /// <summary>
        /// 
        /// </summary>
        Hr,
        /// <summary>
        /// 
        /// </summary>
        SkinTemp,
        /// <summary>
        /// 
        /// </summary>
        SleepClassification,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSleepStreamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSleepStreamType value)
        {
            return value switch
            {
                GetSleepStreamType.BatteryTemp => "battery_temp",
                GetSleepStreamType.BoardTemp => "board_temp",
                GetSleepStreamType.ChargingStatus => "charging_status",
                GetSleepStreamType.Hr => "hr",
                GetSleepStreamType.SkinTemp => "skin_temp",
                GetSleepStreamType.SleepClassification => "sleep_classification",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSleepStreamType? ToEnum(string value)
        {
            return value switch
            {
                "battery_temp" => GetSleepStreamType.BatteryTemp,
                "board_temp" => GetSleepStreamType.BoardTemp,
                "charging_status" => GetSleepStreamType.ChargingStatus,
                "hr" => GetSleepStreamType.Hr,
                "skin_temp" => GetSleepStreamType.SkinTemp,
                "sleep_classification" => GetSleepStreamType.SleepClassification,
                _ => null,
            };
        }
    }
}