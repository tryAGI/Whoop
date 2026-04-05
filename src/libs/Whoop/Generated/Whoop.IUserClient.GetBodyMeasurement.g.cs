#nullable enable

namespace Whoop
{
    public partial interface IUserClient
    {
        /// <summary>
        /// Get User Body Measurements<br/>
        /// Retrieves the body measurements (height, weight, max heart rate) for the authenticated user.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Whoop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Whoop.UserBodyMeasurement> GetBodyMeasurementAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}