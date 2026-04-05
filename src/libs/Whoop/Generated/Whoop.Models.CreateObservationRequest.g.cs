
#nullable enable

namespace Whoop
{
    /// <summary>
    /// optional list of observations to attach to the diagnostic report
    /// </summary>
    public sealed partial class CreateObservationRequest
    {
        /// <summary>
        /// the decimal value for this observation, if there is one
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_numeric")]
        public double? ValueNumeric { get; set; }

        /// <summary>
        /// the text value for this observation, if there is one
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_text")]
        public string? ValueText { get; set; }

        /// <summary>
        /// the unit of this observation value, if there is one
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        public string? Unit { get; set; }

        /// <summary>
        /// the status of this observation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// the code for this observation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateObservationRequest" /> class.
        /// </summary>
        /// <param name="valueNumeric">
        /// the decimal value for this observation, if there is one
        /// </param>
        /// <param name="valueText">
        /// the text value for this observation, if there is one
        /// </param>
        /// <param name="unit">
        /// the unit of this observation value, if there is one
        /// </param>
        /// <param name="status">
        /// the status of this observation
        /// </param>
        /// <param name="code">
        /// the code for this observation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateObservationRequest(
            double? valueNumeric,
            string? valueText,
            string? unit,
            string? status,
            string? code)
        {
            this.ValueNumeric = valueNumeric;
            this.ValueText = valueText;
            this.Unit = unit;
            this.Status = status;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateObservationRequest" /> class.
        /// </summary>
        public CreateObservationRequest()
        {
        }
    }
}