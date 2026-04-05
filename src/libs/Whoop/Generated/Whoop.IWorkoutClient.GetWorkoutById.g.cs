#nullable enable

namespace Whoop
{
    public partial interface IWorkoutClient
    {
        /// <summary>
        /// Get the workout for the specified ID
        /// </summary>
        /// <param name="workoutId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Whoop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Whoop.WorkoutV2> GetWorkoutByIdAsync(
            global::System.Guid workoutId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}