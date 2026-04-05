
#nullable enable

namespace Whoop
{
    /// <summary>
    /// WHOOP's measurements and evaluation of the recovery. Only present if the Recovery State is `SCORED`
    /// </summary>
    public sealed partial class RecoveryScore
    {
        /// <summary>
        /// True if the user is still calibrating and not enough data is available in WHOOP to provide an accurate recovery.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_calibrating")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool UserCalibrating { get; set; }

        /// <summary>
        /// Percentage (0-100%) that reflects how well prepared the user's body is to take on Strain. The Recovery score is a measure of the user body's "return to baseline" after a stressor.<br/>
        /// Example: 44F
        /// </summary>
        /// <example>44F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("recovery_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float RecoveryScore1 { get; set; }

        /// <summary>
        /// The user's resting heart rate.<br/>
        /// Example: 64F
        /// </summary>
        /// <example>64F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resting_heart_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float RestingHeartRate { get; set; }

        /// <summary>
        /// The user's Heart Rate Variability measured using Root Mean Square of Successive Differences (RMSSD), in milliseconds.<br/>
        /// Example: 31.813562F
        /// </summary>
        /// <example>31.813562F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hrv_rmssd_milli")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float HrvRmssdMilli { get; set; }

        /// <summary>
        /// The percentage of oxygen in the user's blood. Only present if the user is on 4.0 or greater.<br/>
        /// Example: 95.6875F
        /// </summary>
        /// <example>95.6875F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("spo2_percentage")]
        public float? Spo2Percentage { get; set; }

        /// <summary>
        /// The user's skin temperature, in Celsius. Only present if the user is on 4.0 or greater.<br/>
        /// Example: 33.7F
        /// </summary>
        /// <example>33.7F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("skin_temp_celsius")]
        public float? SkinTempCelsius { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecoveryScore" /> class.
        /// </summary>
        /// <param name="userCalibrating">
        /// True if the user is still calibrating and not enough data is available in WHOOP to provide an accurate recovery.<br/>
        /// Example: false
        /// </param>
        /// <param name="recoveryScore1">
        /// Percentage (0-100%) that reflects how well prepared the user's body is to take on Strain. The Recovery score is a measure of the user body's "return to baseline" after a stressor.<br/>
        /// Example: 44F
        /// </param>
        /// <param name="restingHeartRate">
        /// The user's resting heart rate.<br/>
        /// Example: 64F
        /// </param>
        /// <param name="hrvRmssdMilli">
        /// The user's Heart Rate Variability measured using Root Mean Square of Successive Differences (RMSSD), in milliseconds.<br/>
        /// Example: 31.813562F
        /// </param>
        /// <param name="spo2Percentage">
        /// The percentage of oxygen in the user's blood. Only present if the user is on 4.0 or greater.<br/>
        /// Example: 95.6875F
        /// </param>
        /// <param name="skinTempCelsius">
        /// The user's skin temperature, in Celsius. Only present if the user is on 4.0 or greater.<br/>
        /// Example: 33.7F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecoveryScore(
            bool userCalibrating,
            float recoveryScore1,
            float restingHeartRate,
            float hrvRmssdMilli,
            float? spo2Percentage,
            float? skinTempCelsius)
        {
            this.UserCalibrating = userCalibrating;
            this.RecoveryScore1 = recoveryScore1;
            this.RestingHeartRate = restingHeartRate;
            this.HrvRmssdMilli = hrvRmssdMilli;
            this.Spo2Percentage = spo2Percentage;
            this.SkinTempCelsius = skinTempCelsius;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecoveryScore" /> class.
        /// </summary>
        public RecoveryScore()
        {
        }
    }
}