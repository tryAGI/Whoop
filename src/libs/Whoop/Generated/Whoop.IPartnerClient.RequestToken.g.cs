#nullable enable

namespace Whoop
{
    public partial interface IPartnerClient
    {
        /// <summary>
        /// Request a partner client token<br/>
        /// Exchanges partner client credentials for an access token.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Whoop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Whoop.PartnerTokenResponse> RequestTokenAsync(

            global::Whoop.PartnerTokenRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Request a partner client token<br/>
        /// Exchanges partner client credentials for an access token.
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Whoop.PartnerTokenResponse> RequestTokenAsync(
            string clientId,
            string clientSecret,
            string? scope = default,
            string? grantType = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}