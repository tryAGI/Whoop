
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Whoop
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Whoop.JsonConverters.CycleScoreStateJsonConverter),

            typeof(global::Whoop.JsonConverters.CycleScoreStateNullableJsonConverter),

            typeof(global::Whoop.JsonConverters.SleepScoreStateJsonConverter),

            typeof(global::Whoop.JsonConverters.SleepScoreStateNullableJsonConverter),

            typeof(global::Whoop.JsonConverters.RecoveryScoreStateJsonConverter),

            typeof(global::Whoop.JsonConverters.RecoveryScoreStateNullableJsonConverter),

            typeof(global::Whoop.JsonConverters.WorkoutV2ScoreStateJsonConverter),

            typeof(global::Whoop.JsonConverters.WorkoutV2ScoreStateNullableJsonConverter),

            typeof(global::Whoop.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Whoop.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Whoop.ActivityIdMappingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Whoop.Cycle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Whoop.CycleScoreState), TypeInfoPropertyName = "CycleScoreState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Whoop.CycleScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Whoop.PaginatedCycleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Whoop.Cycle>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Whoop.Sleep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Whoop.SleepScoreState), TypeInfoPropertyName = "SleepScoreState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Whoop.SleepScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Whoop.SleepNeeded))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Whoop.SleepStageSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Whoop.LabRequisition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Whoop.ServiceRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Whoop.ServiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Whoop.PatientCore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Whoop.Patient))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Whoop.UnilabsPatient))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Whoop.PartnerTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Whoop.PartnerTokenRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Whoop.ServiceRequestStatusRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Whoop.CreateObservationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Whoop.DiagnosticReportCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Whoop.CreateObservationRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Whoop.Recovery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Whoop.RecoveryScoreState), TypeInfoPropertyName = "RecoveryScoreState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Whoop.RecoveryScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Whoop.RecoveryCollection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Whoop.Recovery>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Whoop.PaginatedSleepResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Whoop.Sleep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Whoop.UserBodyMeasurement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Whoop.UserBasicProfile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Whoop.WorkoutScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Whoop.ZoneDurations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Whoop.WorkoutV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Whoop.WorkoutV2ScoreState), TypeInfoPropertyName = "WorkoutV2ScoreState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Whoop.WorkoutCollection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Whoop.WorkoutV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Whoop.Cycle>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Whoop.ServiceRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Whoop.CreateObservationRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Whoop.Recovery>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Whoop.Sleep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Whoop.WorkoutV2>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}