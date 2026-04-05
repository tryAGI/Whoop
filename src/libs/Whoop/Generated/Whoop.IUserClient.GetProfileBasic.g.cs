#nullable enable

namespace Whoop
{
    public partial interface IUserClient
    {
        /// <summary>
        /// Get Basic User Profile<br/>
        /// Retrieves the basic profile information (name, email) for the authenticated user.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Whoop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Whoop.UserBasicProfile> GetProfileBasicAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}