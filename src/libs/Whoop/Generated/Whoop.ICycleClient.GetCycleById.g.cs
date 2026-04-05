#nullable enable

namespace Whoop
{
    public partial interface ICycleClient
    {
        /// <summary>
        /// Get the cycle for the specified ID
        /// </summary>
        /// <param name="cycleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Whoop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Whoop.Cycle> GetCycleByIdAsync(
            long cycleId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}