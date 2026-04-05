#nullable enable

namespace Whoop
{
    public partial interface IUserClient
    {
        /// <summary>
        /// Revoke the access token granted by the user. If the associated OAuth client is configured to receive webhooks, it will no longer receive them for this user.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Whoop.ApiException"></exception>
        global::System.Threading.Tasks.Task RevokeUserOAuthAccessAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}