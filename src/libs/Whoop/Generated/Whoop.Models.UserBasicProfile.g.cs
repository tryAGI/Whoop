
#nullable enable

namespace Whoop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserBasicProfile
    {
        /// <summary>
        /// The WHOOP User<br/>
        /// Example: 10129
        /// </summary>
        /// <example>10129</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long UserId { get; set; }

        /// <summary>
        /// User's Email<br/>
        /// Example: jsmith123@whoop.com
        /// </summary>
        /// <example>jsmith123@whoop.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// User's First Name<br/>
        /// Example: John
        /// </summary>
        /// <example>John</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FirstName { get; set; }

        /// <summary>
        /// User's Last Name<br/>
        /// Example: Smith
        /// </summary>
        /// <example>Smith</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserBasicProfile" /> class.
        /// </summary>
        /// <param name="userId">
        /// The WHOOP User<br/>
        /// Example: 10129
        /// </param>
        /// <param name="email">
        /// User's Email<br/>
        /// Example: jsmith123@whoop.com
        /// </param>
        /// <param name="firstName">
        /// User's First Name<br/>
        /// Example: John
        /// </param>
        /// <param name="lastName">
        /// User's Last Name<br/>
        /// Example: Smith
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserBasicProfile(
            long userId,
            string email,
            string firstName,
            string lastName)
        {
            this.UserId = userId;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.FirstName = firstName ?? throw new global::System.ArgumentNullException(nameof(firstName));
            this.LastName = lastName ?? throw new global::System.ArgumentNullException(nameof(lastName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserBasicProfile" /> class.
        /// </summary>
        public UserBasicProfile()
        {
        }
    }
}