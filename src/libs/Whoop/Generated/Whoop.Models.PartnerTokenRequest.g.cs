
#nullable enable

namespace Whoop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PartnerTokenRequest
    {
        /// <summary>
        /// client id for this partner
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientSecret { get; set; }

        /// <summary>
        /// scope for this token request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string? Scope { get; set; }

        /// <summary>
        /// grant type for this token request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grant_type")]
        public string? GrantType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartnerTokenRequest" /> class.
        /// </summary>
        /// <param name="clientId">
        /// client id for this partner
        /// </param>
        /// <param name="clientSecret"></param>
        /// <param name="scope">
        /// scope for this token request
        /// </param>
        /// <param name="grantType">
        /// grant type for this token request
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartnerTokenRequest(
            string clientId,
            string clientSecret,
            string? scope,
            string? grantType)
        {
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.ClientSecret = clientSecret ?? throw new global::System.ArgumentNullException(nameof(clientSecret));
            this.Scope = scope;
            this.GrantType = grantType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartnerTokenRequest" /> class.
        /// </summary>
        public PartnerTokenRequest()
        {
        }
    }
}