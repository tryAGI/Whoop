#nullable enable

namespace Whoop
{
    public partial interface IRecoveryClient
    {
        /// <summary>
        /// Get the recovery for a cycle
        /// </summary>
        /// <param name="cycleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Whoop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Whoop.Recovery> GetRecoveryForCycleAsync(
            long cycleId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}