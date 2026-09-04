
#nullable enable

namespace Whoop
{
    /// <summary>
    /// Default Value: IN_PERSON
    /// </summary>
    public enum AddTestDataAppointmentType
    {
        /// <summary>
        /// IN_PERSON (default, lab collection) or MOBILE (home collection, includes collection_address).
        /// </summary>
        InPerson,
        /// <summary>
        /// IN_PERSON (default, lab collection) or MOBILE (home collection, includes collection_address).
        /// </summary>
        Mobile,
        /// <summary>
        ///
        /// </summary>
        Virtual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AddTestDataAppointmentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddTestDataAppointmentType value)
        {
            return value switch
            {
                AddTestDataAppointmentType.InPerson => "IN_PERSON",
                AddTestDataAppointmentType.Mobile => "MOBILE",
                AddTestDataAppointmentType.Virtual => "VIRTUAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddTestDataAppointmentType? ToEnum(string value)
        {
            return value switch
            {
                "IN_PERSON" => AddTestDataAppointmentType.InPerson,
                "MOBILE" => AddTestDataAppointmentType.Mobile,
                "VIRTUAL" => AddTestDataAppointmentType.Virtual,
                _ => null,
            };
        }
    }
}