#pragma warning disable CS3002 // Return type is not CLS-compliant
using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace tryAGI.Whoop;

/// <summary>
/// MEAI AIFunction tool extensions for WhoopClient.
/// </summary>
public static partial class WhoopClientExtensions
{
    /// <summary>
    /// Returns all AIFunction tools for the Whoop client.
    /// </summary>
    /// <param name="client">The Whoop client.</param>
    /// <returns>A list of AIFunction tools that can be passed to ChatOptions.Tools.</returns>
    public static IList<AIFunction> AsTools(this global::Whoop.WhoopClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return
        [
            client.AsGetRecoveryCollectionTool(),
            client.AsGetSleepCollectionTool(),
            client.AsGetWorkoutCollectionTool(),
            client.AsGetProfileTool(),
        ];
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that gets recovery data for the user.
    /// </summary>
    /// <param name="client">The Whoop client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGetRecoveryCollectionTool(this global::Whoop.WhoopClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [Description("Maximum number of records to return (default 10)")] int? limit,
                [Description("Start date/time filter (ISO 8601)")] DateTime? start,
                [Description("End date/time filter (ISO 8601)")] DateTime? end,
                CancellationToken cancellationToken) =>
            {
                var response = await client.Recovery.GetRecoveryCollectionAsync(
                    limit: limit,
                    start: start,
                    end: end,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    Records = response.Records?.Select(r => new
                    {
                        r.CycleId,
                        r.SleepId,
                        r.CreatedAt,
                        ScoreState = r.ScoreState.ToString(),
                        RecoveryScore = r.Score?.RecoveryScore1,
                        RestingHeartRate = r.Score?.RestingHeartRate,
                        HrvRmssdMilli = r.Score?.HrvRmssdMilli,
                        Spo2Percentage = r.Score?.Spo2Percentage,
                        SkinTempCelsius = r.Score?.SkinTempCelsius,
                    }),
                    response.NextToken,
                };
            },
            name: "Whoop_GetRecoveryCollection",
            description: "Get the authenticated user's recovery scores from WHOOP, including recovery percentage, resting heart rate, HRV, SpO2, and skin temperature. Results are paginated and sorted by most recent first.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that gets sleep data for the user.
    /// </summary>
    /// <param name="client">The Whoop client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGetSleepCollectionTool(this global::Whoop.WhoopClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [Description("Maximum number of records to return (default 10)")] int? limit,
                [Description("Start date/time filter (ISO 8601)")] DateTime? start,
                [Description("End date/time filter (ISO 8601)")] DateTime? end,
                CancellationToken cancellationToken) =>
            {
                var response = await client.Sleep.GetSleepCollectionAsync(
                    limit: limit,
                    start: start,
                    end: end,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    Records = response.Records?.Select(s => new
                    {
                        s.Id,
                        s.Start,
                        s.End,
                        s.Nap,
                        ScoreState = s.ScoreState.ToString(),
                        SleepPerformance = s.Score?.SleepPerformancePercentage,
                        SleepEfficiency = s.Score?.SleepEfficiencyPercentage,
                        SleepConsistency = s.Score?.SleepConsistencyPercentage,
                        RespiratoryRate = s.Score?.RespiratoryRate,
                    }),
                    response.NextToken,
                };
            },
            name: "Whoop_GetSleepCollection",
            description: "Get the authenticated user's sleep data from WHOOP, including sleep performance percentage, efficiency, consistency, and respiratory rate. Results are paginated and sorted by most recent first.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that gets workout data for the user.
    /// </summary>
    /// <param name="client">The Whoop client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGetWorkoutCollectionTool(this global::Whoop.WhoopClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [Description("Maximum number of records to return (default 10)")] int? limit,
                [Description("Start date/time filter (ISO 8601)")] DateTime? start,
                [Description("End date/time filter (ISO 8601)")] DateTime? end,
                CancellationToken cancellationToken) =>
            {
                var response = await client.Workout.GetWorkoutCollectionAsync(
                    limit: limit,
                    start: start,
                    end: end,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    Records = response.Records?.Select(w => new
                    {
                        w.Id,
                        w.SportName,
                        w.Start,
                        w.End,
                        ScoreState = w.ScoreState.ToString(),
                        Strain = w.Score?.Strain,
                        AverageHeartRate = w.Score?.AverageHeartRate,
                        MaxHeartRate = w.Score?.MaxHeartRate,
                        Kilojoules = w.Score?.Kilojoule,
                        DistanceMeter = w.Score?.DistanceMeter,
                    }),
                    response.NextToken,
                };
            },
            name: "Whoop_GetWorkoutCollection",
            description: "Get the authenticated user's workout data from WHOOP, including strain score, sport name, average/max heart rate, kilojoules burned, and distance. Results are paginated and sorted by most recent first.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that gets the user's profile and body measurements.
    /// </summary>
    /// <param name="client">The Whoop client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGetProfileTool(this global::Whoop.WhoopClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var profile = await client.User.GetProfileBasicAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                var body = await client.User.GetBodyMeasurementAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    profile.UserId,
                    profile.Email,
                    profile.FirstName,
                    profile.LastName,
                    body.HeightMeter,
                    body.WeightKilogram,
                    body.MaxHeartRate,
                };
            },
            name: "Whoop_GetProfile",
            description: "Get the authenticated user's WHOOP profile including name, email, height, weight, and max heart rate.");
    }
}
