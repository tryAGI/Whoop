#nullable enable

namespace Whoop
{
    public partial interface IRecoveryClient
    {
        /// <summary>
        /// Get all recoveries for a user, paginated. Results are sorted by start time of the related sleep in descending order.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="nextToken"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Whoop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Whoop.RecoveryCollection> GetRecoveryCollectionAsync(
            int? limit = default,
            global::System.DateTime? start = default,
            global::System.DateTime? end = default,
            string? nextToken = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}