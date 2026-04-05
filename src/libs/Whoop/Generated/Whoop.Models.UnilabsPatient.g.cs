
#nullable enable

namespace Whoop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnilabsPatient
    {
        /// <summary>
        /// First name of the patient
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FirstName { get; set; }

        /// <summary>
        /// Last name of the patient
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastName { get; set; }

        /// <summary>
        /// Birth date of the patient
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("birth_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime BirthDate { get; set; }

        /// <summary>
        /// Unique identifier for the patient
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnilabsPatient" /> class.
        /// </summary>
        /// <param name="firstName">
        /// First name of the patient
        /// </param>
        /// <param name="lastName">
        /// Last name of the patient
        /// </param>
        /// <param name="birthDate">
        /// Birth date of the patient
        /// </param>
        /// <param name="id">
        /// Unique identifier for the patient
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnilabsPatient(
            string firstName,
            string lastName,
            global::System.DateTime birthDate,
            global::System.Guid id)
        {
            this.FirstName = firstName ?? throw new global::System.ArgumentNullException(nameof(firstName));
            this.LastName = lastName ?? throw new global::System.ArgumentNullException(nameof(lastName));
            this.BirthDate = birthDate;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnilabsPatient" /> class.
        /// </summary>
        public UnilabsPatient()
        {
        }
    }
}