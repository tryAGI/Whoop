#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Whoop
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct UnilabsAppointment : global::System.IEquatable<UnilabsAppointment>
    {
        /// <summary>
        /// Appointment information
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Whoop.Appointment? Appointment { get; init; }
#else
        public global::Whoop.Appointment? Appointment { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Appointment))]
#endif
        public bool IsAppointment => Appointment != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppointment(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Whoop.Appointment? value)
        {
            value = Appointment;
            return IsAppointment;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Whoop.Appointment PickAppointment() => IsAppointment
            ? Appointment!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Appointment' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Whoop.UnilabsAppointmentVariant2? UnilabsAppointmentVariant2 { get; init; }
#else
        public global::Whoop.UnilabsAppointmentVariant2? UnilabsAppointmentVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnilabsAppointmentVariant2))]
#endif
        public bool IsUnilabsAppointmentVariant2 => UnilabsAppointmentVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnilabsAppointmentVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Whoop.UnilabsAppointmentVariant2? value)
        {
            value = UnilabsAppointmentVariant2;
            return IsUnilabsAppointmentVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Whoop.UnilabsAppointmentVariant2 PickUnilabsAppointmentVariant2() => IsUnilabsAppointmentVariant2
            ? UnilabsAppointmentVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnilabsAppointmentVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnilabsAppointment(global::Whoop.Appointment value) => new UnilabsAppointment((global::Whoop.Appointment?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Whoop.Appointment?(UnilabsAppointment @this) => @this.Appointment;

        /// <summary>
        ///
        /// </summary>
        public UnilabsAppointment(global::Whoop.Appointment? value)
        {
            Appointment = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnilabsAppointment FromAppointment(global::Whoop.Appointment? value) => new UnilabsAppointment(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UnilabsAppointment(global::Whoop.UnilabsAppointmentVariant2 value) => new UnilabsAppointment((global::Whoop.UnilabsAppointmentVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Whoop.UnilabsAppointmentVariant2?(UnilabsAppointment @this) => @this.UnilabsAppointmentVariant2;

        /// <summary>
        ///
        /// </summary>
        public UnilabsAppointment(global::Whoop.UnilabsAppointmentVariant2? value)
        {
            UnilabsAppointmentVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UnilabsAppointment FromUnilabsAppointmentVariant2(global::Whoop.UnilabsAppointmentVariant2? value) => new UnilabsAppointment(value);

        /// <summary>
        ///
        /// </summary>
        public UnilabsAppointment(
            global::Whoop.Appointment? appointment,
            global::Whoop.UnilabsAppointmentVariant2? unilabsAppointmentVariant2
            )
        {
            Appointment = appointment;
            UnilabsAppointmentVariant2 = unilabsAppointmentVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            UnilabsAppointmentVariant2 as object ??
            Appointment as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Appointment?.ToString() ??
            UnilabsAppointmentVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppointment && IsUnilabsAppointmentVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Whoop.Appointment, TResult>? appointment = null,
            global::System.Func<global::Whoop.UnilabsAppointmentVariant2, TResult>? unilabsAppointmentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppointment && appointment != null)
            {
                return appointment(Appointment!);
            }
            else if (IsUnilabsAppointmentVariant2 && unilabsAppointmentVariant2 != null)
            {
                return unilabsAppointmentVariant2(UnilabsAppointmentVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Whoop.Appointment>? appointment = null,

            global::System.Action<global::Whoop.UnilabsAppointmentVariant2>? unilabsAppointmentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppointment)
            {
                appointment?.Invoke(Appointment!);
            }
            else if (IsUnilabsAppointmentVariant2)
            {
                unilabsAppointmentVariant2?.Invoke(UnilabsAppointmentVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Whoop.Appointment>? appointment = null,
            global::System.Action<global::Whoop.UnilabsAppointmentVariant2>? unilabsAppointmentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppointment)
            {
                appointment?.Invoke(Appointment!);
            }
            else if (IsUnilabsAppointmentVariant2)
            {
                unilabsAppointmentVariant2?.Invoke(UnilabsAppointmentVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Appointment,
                typeof(global::Whoop.Appointment),
                UnilabsAppointmentVariant2,
                typeof(global::Whoop.UnilabsAppointmentVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(UnilabsAppointment other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Whoop.Appointment?>.Default.Equals(Appointment, other.Appointment) &&
                global::System.Collections.Generic.EqualityComparer<global::Whoop.UnilabsAppointmentVariant2?>.Default.Equals(UnilabsAppointmentVariant2, other.UnilabsAppointmentVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(UnilabsAppointment obj1, UnilabsAppointment obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UnilabsAppointment>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(UnilabsAppointment obj1, UnilabsAppointment obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UnilabsAppointment o && Equals(o);
        }
    }
}
