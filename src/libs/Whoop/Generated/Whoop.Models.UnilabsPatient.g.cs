
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
        /// Gender of the patient
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        public string? Gender { get; set; }

        /// <summary>
        /// Email address of the patient
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Phone number of the patient
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone")]
        public string? Phone { get; set; }

        /// <summary>
        /// Nationality of the patient
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nationality")]
        public string? Nationality { get; set; }

        /// <summary>
        /// Unique identifier for the patient
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Emirates ID of the patient
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emirates_id")]
        public string? EmiratesId { get; set; }

        /// <summary>
        /// Passport number of the patient
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passport_no")]
        public string? PassportNo { get; set; }

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
        /// <param name="gender">
        /// Gender of the patient
        /// </param>
        /// <param name="email">
        /// Email address of the patient
        /// </param>
        /// <param name="phone">
        /// Phone number of the patient
        /// </param>
        /// <param name="nationality">
        /// Nationality of the patient
        /// </param>
        /// <param name="emiratesId">
        /// Emirates ID of the patient
        /// </param>
        /// <param name="passportNo">
        /// Passport number of the patient
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnilabsPatient(
            string firstName,
            string lastName,
            global::System.DateTime birthDate,
            global::System.Guid id,
            string? gender,
            string? email,
            string? phone,
            string? nationality,
            string? emiratesId,
            string? passportNo)
        {
            this.FirstName = firstName ?? throw new global::System.ArgumentNullException(nameof(firstName));
            this.LastName = lastName ?? throw new global::System.ArgumentNullException(nameof(lastName));
            this.BirthDate = birthDate;
            this.Gender = gender;
            this.Email = email;
            this.Phone = phone;
            this.Nationality = nationality;
            this.Id = id;
            this.EmiratesId = emiratesId;
            this.PassportNo = passportNo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnilabsPatient" /> class.
        /// </summary>
        public UnilabsPatient()
        {
        }
    }
}